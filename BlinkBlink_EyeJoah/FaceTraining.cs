using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;


namespace BlinkBlink_EyeJoah
{
    public partial class FaceTraining : Form
    {
        /* Training Data가 들어있는 Class */
        TrainingData trainingData;
        
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, trainedFace = null;
        Image<Gray, byte> gray = null;
        Bitmap captureBitmap;

        /* Training Image 및 이름에 관한 변수 */
        List<Image<Gray, byte>> trainingImages;
        List<string> trainedNamesList;

        /* shoot 버튼을 눌렀는지 확인하는 변수 */
        private Boolean clickedShootBtn = false;

        #region 마우스로 Form 이동에 관한 변수
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        #region WebCam load에 대한 변수
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        #endregion


        public FaceTraining()
        {
            InitializeComponent();

            takePic_NextBtn.Image = Properties.Resources.OpenCamera1;
            //얼굴 검출을 위한 Haarcascade Load
            face = new HaarCascade("haarcascade_frontalface_default.xml");

            //Training 폴더에 있는 얼굴 이미지 및 이름들 불러오기
            loadTrainingImage();
            //WebCam 장치 이름을 불러오기
            loadWebCamDevice();
            //PictureBox UI 둥글게 하기
            makePictureBoxToRound();

            //Capture Device 초기화
            grabber = new Capture();

            //Idle 대신 Timer로 FrameGraber event 실행
            timer1.Tick += new EventHandler(FrameGrabber);
            timer1.Start();
        }
        
        private void FrameGrabber(object sender, EventArgs e)
        {
            //현재 Frame을 Capture Device를 통해 얻기       
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Grayscale로 현재 Frame 바꾼것 gray 변수에 저장
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detect
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //Detect한 얼굴들(elements) 작업
            foreach (MCvAvgComp face in facesDetected[0])
            {
                //result 변수에 현재 잡힌 얼굴 저장.( 얼굴 training 등록할 때 쓰임 )
                result = currentFrame.Copy(face.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //잡힌 얼굴 사각형으로 그리기
                currentFrame.Draw(face.rect, new Bgr(Color.CadetBlue), 3);
                //잡힌 얼굴 cature시 띄어줄 사진 Bitmap으로 변환
                captureBitmap = currentFrame.Copy(face.rect).Bitmap;

                //잡힌 얼굴 비교하기 ( Training안에 있는 이미지를 통해 )
                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(trainingData.getset_CountTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), trainedNamesList.ToArray(), 3000, ref termCrit);
                    //해당 검출한 Face의 이름 찾기
                    String name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new System.Drawing.Point(face.rect.X - 2, face.rect.Y - 2), new Bgr(Color.LightGreen));
                }
            }
            
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
        }

        private void takePictureBtn_Click(object sender, EventArgs e)
        {
            // Shoot 버튼을 누른 상태일 경우 ( Next버튼으로 변한 상태 ) 
            if (clickedShootBtn.Equals(true))
            {
                // 현재 Form을 숨기고 Timer 기능 Stop 
                this.Hide();
                timer1.Stop();
                // MainForm 띄우기 
                Form1 mainForm = new Form1();
                mainForm.Show();
                mainForm.Activate();
            }
            // Shoot 버튼을 한번도 안 눌렀을 경우
            else
            {
                if (nameTxtbox.Text.Equals("Insert name") ||
                    nameTxtbox.Text.Length.Equals(0))
                {
                    MessageBox.Show("Please input your name");
                    return;
                }
                // user 등록하기 
                add_User_To_TrainingImage();
                // 버튼을 Next 사진으로 변경 후 Click 했음을 나타내는 clickedShootBtn = true로 변경 
                takePic_NextBtn.Image = Properties.Resources._checked;
                clickedShootBtn = true;
            }
        }
        private void reTryBtn_Click(object sender, MouseEventArgs e)
        {
            reTryBtn.Visible = false;
            pictureBox1.Image = null;
        }
        private void nameTxtbox_MouseClick(object sender, MouseEventArgs e)
        {
            nameTxtbox.Clear();
            nameTxtbox.ForeColor = Color.Black;
        }

        private void loadWebCamDevice()
        {
            //VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            //{
            //    comboBox1.Items.Add(VideoCaptureDevice.Name);
            //}
            //comboBox1.Items.Add("Smart Phone");
            //comboBox1.SelectedIndex = 0;
        }
        private void loadTrainingImage()
        {
            // trainingData 객체 참조
            trainingData = TrainingData.Instance;

            // trainingImage에 관한 Data Load하기 + load된 Data들 참조
            trainingData.loadTrainingData();
            trainingImages = trainingData.getset_TrainingImages;
            trainedNamesList = trainingData.getset_trainedNamesList;
        }

        private void add_User_To_TrainingImage()
        {
            try
            {
                // Training Image 카운트 증가
                trainingData.getset_CountTrain = trainingData.getset_CountTrain + 1;
                
                // 검출한 얼굴 이미지 100X100으로 사이즈 재조정 및 TrainingImage List에 저장
                trainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingData.getset_TrainingImages.Add(trainedFace);
                trainingData.getset_trainedNamesList.Add(nameTxtbox.Text);
                
                // 파일에 위 Data 저장하기
                trainingData.saveTrainingData();

                // 등록한 얼굴을 100X100형태로 imageBox1에 투영
                captureBitmap = ResizeImage(captureBitmap, new Size(100, 100));
                pictureBox1.Image = captureBitmap;
                
                reTryBtn.Visible = true;
                MessageBox.Show(nameTxtbox.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void closeButton_Click(object sender, MouseEventArgs e)
        {
            //프로그램 종료
            Application.Exit();
        }

        private void makePictureBoxToRound()
        {
            Rectangle r = new Rectangle(0, 0, imageBoxFrameGrabber.Width, imageBoxFrameGrabber.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 50;
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            imageBoxFrameGrabber.Region = new Region(gp);
        }

        // Capture된 사진 Size 조절하는 Method
        private static Bitmap ResizeImage(Bitmap image, Size newSize)
        {
            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage((System.Drawing.Image)newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newSize.Width, newSize.Height);
            }
            return newImage;
        }

    }
}