﻿using System;
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
        #region Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, trainedFace = null;
        Image<Gray, byte> gray = null;
        Bitmap captureBitmap;

        /* training에 관한 변수들 */
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> trainedNamesList = new List<string>();
        int CountTrain = 0;
        string name = null;
        #endregion

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

        private Boolean clickedShootBtn = false;  // shoot 버튼을 눌렀는지 확인하는 변수
        private String userName = null;

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
                    MCvTermCriteria termCrit = new MCvTermCriteria(CountTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), trainedNamesList.ToArray(), 3000, ref termCrit);
                    //해당 검출한 Face의 이름 찾기
                    name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new System.Drawing.Point(face.rect.X - 2, face.rect.Y - 2), new Bgr(Color.LightGreen));
                }
            }
            
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
        }

        private void takePictureBtn_Click(object sender, EventArgs e)
        {
            if (clickedShootBtn.Equals(true))
            {
                this.Hide();
                timer1.Stop();

                Form1 mainForm = new Form1();
                mainForm.Show();
                mainForm.Activate();
            }
            else
            {
                if (nameTxtbox.Text.Equals("Insert name") ||
                    nameTxtbox.Text.Length.Equals(0))
                {
                    MessageBox.Show("Please input your name");
                    return;
                }
                // user 등록하기
                takePic_NextBtn.Image = Properties.Resources._checked;
                add_User_To_TrainingImage();
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

        private void loadTrainingImage()
        {
            try
            {
                //파일에 있는 Training Image 및 label load.
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] trainedNames = Labelsinfo.Split('%');
                CountTrain = Convert.ToInt16(trainedNames[0]);

                // 파일에 있는 TrainingImage List에 저장
                string LoadFaces;
                for (int tf = 1; tf < CountTrain + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    trainedNamesList.Add(trainedNames[tf]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
        private void add_User_To_TrainingImage()
        {
            try
            {
                //카운터 증가
                CountTrain = CountTrain + 1;

                //현재 CaptureFrame 320X240 사이즈로 저장
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //얼굴 검출 시작
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(face, 1.1, 0, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));

                //검출한 이미지 100X100으로 사이즈 재조정 및 TrainingImage List에 저장
                trainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(trainedFace);
                trainedNamesList.Add(nameTxtbox.Text);

                //등록한 얼굴을 100X100형태로 imageBox1에 투영
                captureBitmap = ResizeImage(captureBitmap, new Size(100, 100));
                pictureBox1.Image = captureBitmap;

                //등록한 얼굴 수 TrainedLabels.txt에 저장 --> WriteAllText를 통해 File 존재시 덮어씀
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //등록한 얼굴 bmp 파일로 저장 및 이름 TrainedLabels.txt에 저장
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainedNamesList.ToArray()[i - 1] + "%");
                }

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

        public List<Image<Gray, byte>> getTrainingImages
        {
            get { return trainingImages; }
        }
        public String getUserName
        {
            get { return userName; }
        }
        public int getCountTrain
        {
            get { return CountTrain; }
        }
    }
}