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

//azure database
using DT = System.Data;            // System.Data.dll  
using QC = System.Data.SqlClient;  // System.Data.dll  

namespace BlinkBlink_EyeJoah
{
    public partial class FaceTraining : Form
    {
        /* Training Data가 들어있는 Class */
        private TrainingData trainingData;

        private Image<Bgr, Byte> currentFrame;
        private Capture grabber;
        private HaarCascade face;

        private Image<Gray, byte> result, trainedFace = null;
        private Image<Gray, byte> gray = null;
        private Bitmap captureBitmap;                                                         // Capture된 Face
        private MCvAvgComp f;                                                                 // 얼굴 검출된 face
        public static MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);   // Font
        /* Training Image 및 이름에 관한 변수 */
        private List<Image<Gray, byte>> trainingImages;
        private List<string> trainedNamesList;

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

        //가장자리 둥글게
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
 );

        //nickname check-azure database
        private bool checkNameDup;

        public FaceTraining()
        {
            InitializeComponent();

            //가장자리 둥글게
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            //얼굴 검출을 위한 Haarcascade Load
            face = new HaarCascade("haarcascade_frontalface_default.xml");

            //Training 폴더에 있는 얼굴 이미지 및 이름들 불러오기
            loadTrainingImage();
            //WebCam 장치 이름을 불러오기
            loadWebCamDevice();
            //PictureBox UI 둥글게 하기
            //makePictureBoxToRound();

            //Capture Device 초기화
            grabber = new Capture();

            //Idle 대신 Timer로 FrameGraber event 실행
            timer1.Tick += new EventHandler(FrameGrabber);
            timer1.Start();

            //access controls from another classes
            faceTraining = this;
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
                f = face;
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
            currentFrame.Draw(f.rect, new Bgr(Color.CadetBlue), 3);
            imageBoxFrameGrabber.Image = currentFrame;
        }

        //private void takePictureBtn_Click(object sender, MouseEventArgs e)
        //{
        //    //// Shoot 버튼을 누른 상태일 경우 ( Next버튼으로 변한 상태 ) 
        //    //if (clickedShootBtn.Equals(true))
        //    //{
        //    //    // userName을 Text파일에 저장하기( 덮어쓰기 )
        //    //    File.WriteAllText(Application.StartupPath + "/TrainedFaces/UserName.txt", nameTxtbox.Text);
        //    //    // MainForm 띄우기
        //    //    showMainForm();
        //    //}
        //    //// Shoot 버튼을 한번도 안 눌렀을 경우
        //    //else
        //    //{
        //    //    if (nameTxtbox.Text.Equals("insert nickname") ||
        //    //        nameTxtbox.Text.Length.Equals(0))
        //    //    {
        //    //        MessageBox.Show("Please input your name");
        //    //        return;
        //    //    }
        //    //    // user 등록하기 
        //    //    add_User_To_TrainingImage();
        //    //    // 버튼을 Next 사진으로 변경 후 Click 했음을 나타내는 clickedShootBtn = true로 변경 
        //    //    takePic_NextBtn.Image = Properties.Resources._checked;
        //    //    clickedShootBtn = true;
        //    //}

        //}

        //private void reTryBtn_Click(object sender, MouseEventArgs e)
        //{
        //    reTryBtn.Visible = false;
        //    pictureBox1.Image = null;
        //}

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
                takePic.Text = "Try again";
                // Training Image 카운트 증가
                trainingData.getset_CountTrain = trainingData.getset_CountTrain + 1;

                // 검출한 얼굴 이미지 100X100으로 사이즈 재조정 및 TrainingImage List에 저장
                trainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingData.getset_TrainingImages.Add(trainedFace);
                trainingData.getset_trainedNamesList.Add(nameTxtbox.Text);

                // 파일에 위 Data 저장하기
                trainingData.saveTrainingData();

                // 등록한 얼굴을 100X100형태로 imageBox1에 투영
                captureBitmap = ResizeImage.adjust(captureBitmap, new Size(120, 120));
                pictureBox1.Image = captureBitmap;

                MessageBox.Show(nameTxtbox.Text + "´s face was detected and registered. :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void showMainForm()
        {
            // 현재 Form을 숨기고 Timer 기능 Stop 
            this.Hide();
            timer1.Stop();
            // MainForm 띄우기 
            Form1 mainForm = new Form1();
            mainForm.Show();
            mainForm.Activate();
        }

        private void takePic_Click(object sender, EventArgs e)
        {
            // Shoot 두번째 눌렀을 경우, 
            if (clickedShootBtn.Equals(true))
            {
                //새로고침
                pictureBox1.Image = null;
                clickedShootBtn = false;
                takePic.Text = "Take a picture";
            }

            //shoot 세번째 눌렀을 경우,
            // Shoot 버튼을 한번도 안 눌렀을 경우
            else
            {
                if (takePic.Text.Equals("Take a picture"))
                {
                    // 버튼을 Next 사진으로 변경 후 Click 했음을 나타내는 clickedShootBtn = true로 변경 
                    clickedShootBtn = true;
                }
                if (nameTxtbox.Text.Equals("insert nickname") ||
                    nameTxtbox.Text.Length.Equals(0))
                {
                    MessageBox.Show("Please input your name.");
                    return;
                }
                // user 등록하기 
                add_User_To_TrainingImage();

            }
        }

        //access UserInfoAzureDb
        UserInfoAzureDB userInfoAzureDB = UserInfoAzureDB.getInstance();
        //access controls from another classes
        public static FaceTraining faceTraining;

        //update checkNameDup(bool)
        public void updateNameDup(bool boolValue)
        {
            checkNameDup = boolValue;
        }
        //update nicknameCheckText
        public void updateCheckText(String message, Color color)
        {
            nicknameCheckTxt.Text = message;
            nicknameCheckTxt.ForeColor = color;
        }
        public String nameText()
        {
            return nameTxtbox.Text;
        }


        //insert data and go to the next form
        private void goNext_Click(object sender, EventArgs e)
        {
            if (checkNameDup == true)
            {

                userInfoAzureDB.insertData(nameTxtbox.Text);

                // userName을 Text파일에 저장하기( 덮어쓰기 )
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/UserName.txt", nameTxtbox.Text);
                // MainForm 띄우기
                showMainForm();
            }
            else if (checkNameDup == false)
            {
                MessageBox.Show("Check your nickname");
            }
        }

        private void idCheck_Click(object sender, EventArgs e)
        {
            userInfoAzureDB.idDupCheck();
        }

    }
}