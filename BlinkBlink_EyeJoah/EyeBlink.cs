using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.VideoSurveillance;
using System.Threading;

using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;


namespace BlinkBlink_EyeJoah
{
    class EyeBlink
    {
        /* Form1 UI 함수 */
        private Form1 mainForm;
        private Emgu.CV.UI.ImageBox imageBoxCapturedFrame, leftEyeImageBox, rightEyeImageBox;
        private Label thresholdValueText, eyeBlinkNumText;

        private Capture _capture;
        private HaarCascade _faces;
        private Image<Bgr, Byte> frame;
        private BackgroundWorker worker;
        public static int TV = 0;               // TV = Label에 현재 Threshold값 띄어주기 위해 저장하는 변수

        private MCvAvgComp face;
        private Rectangle possibleROI_rightEye, possibleROI_leftEye;
        private LineSegment2D a, b, c;
        private Bgr d;

        private Bitmap Thimage;

        private int blurAmount = 1;
        private int thresholdValue = 30;
        private int prevThresholdValue = 0;
        private int blinkNum = 0;

        private List<int> averageThresholdValue;
        public static Boolean catchBlackPixel = false;
        public static Boolean catchBlink = false;

        // constructor(생성자)
        public EyeBlink(Emgu.CV.UI.ImageBox imageBoxCapturedFrame, 
                        Emgu.CV.UI.ImageBox leftEyeImageBox, Emgu.CV.UI.ImageBox rightEyeImageBox, 
                        Label thresholdValue, Label eyeBlinkNum)
        {
            this.imageBoxCapturedFrame = imageBoxCapturedFrame;
            this.leftEyeImageBox = leftEyeImageBox;
            this.rightEyeImageBox = rightEyeImageBox;
            this.thresholdValueText = thresholdValue;
            this.eyeBlinkNumText = eyeBlinkNum;
        }

        public void start_EyeBlink()
        {
            // capture 생성
            if (_capture == null)
            {
                try
                {
                    _capture = new Capture();
                    _faces = new HaarCascade("haarcascade_frontalface_alt_tree.xml");

                    // 평균 Threadhold값 저장하는 list 생성
                    averageThresholdValue = new List<int>();

                    // Blink 기능 수행하는 Thread 생성
                    worker = new BackgroundWorker();
                    worker.WorkerReportsProgress = true;
                    worker.WorkerSupportsCancellation = true;
                    worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                    worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
                    worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

                }
                catch (NullReferenceException excpt) { }
            }

            // capture가 생성 됐다면 EventHandler 추가 및 실행
            if (_capture != null)
            {
                Application.Idle += FrameGrabber;
            }
        }
        

        void FrameGrabber(object sender, EventArgs e)
        {
            //새로운 Frame 얻은 후 ImageBox에 투영하기
            frame = _capture.QueryFrame();
            imageBoxCapturedFrame.Image = frame;

            //grayscale로 변환( haarcascade를 적용할 땐 회색 화면을 더 잘 잡는다고 함 )
            Image<Gray, Byte> grayFrame = frame.Convert<Gray, Byte>();
            grayFrame._EqualizeHist();

            // EventHandler 주기마다 Detect한 얼굴 사각형으로 그리기
            if (!face.Equals(null))
            {
                frame.Draw(face.rect, new Bgr(Color.Violet), 2);
            }
            // worker 쓰레드 실행
            if (!worker.IsBusy)
                worker.RunWorkerAsync(grayFrame);

            #region 눈 영역이 Null이 아닐 경우
            // EventHandler 주기마다 worker(Thread)에서 Detect 성공한 눈 영역을 ImageBox에 투영,
            // 그리고 threshold를 통한 눈 깜빡임 횟수 검출하는 thresholdEffect() 함수 실행
            if (possibleROI_rightEye.IsEmpty.Equals(false) && possibleROI_leftEye.IsEmpty.Equals(false))
            {
                try
                {
                    rightEyeImageBox.Image = frame.Copy(possibleROI_rightEye).Convert<Bgr, byte>();
                    leftEyeImageBox.Image = frame.Copy(possibleROI_leftEye).Convert<Bgr, byte>();

                    // 실행하기전 눈 깜빡임을 판단하는 catchBlackPixel 값 false로 초기화
                    EyeBlink.catchBlackPixel = false;
                    //thresholdEffect(thresholdValue);
                }
                catch (ArgumentException expt) { }
            }
            #endregion
        }//FrameGrapper


        // Worker Thread가 실제 하는 일
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Image<Gray, Byte> grayFrame = (Image<Gray, Byte>)e.Argument;
            // 머신러닝을 이용한 얼굴 인식 Haaracascade 돌리기
            MCvAvgComp[][] facesDetected = grayFrame.DetectHaarCascade(_faces, 1.1, 0, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));
            if (facesDetected[0].Length != 0)
            {
                face = facesDetected[0][0];

                #region 얼굴 인식한것을 토대로 눈 찾기
                Int32 yCoordStartSearchEyes = face.rect.Top + (face.rect.Height * 3 / 11);
                System.Drawing.Point startingPointSearchEyes = new System.Drawing.Point(face.rect.X, yCoordStartSearchEyes);
                System.Drawing.Point endingPointSearchEyes = new System.Drawing.Point((face.rect.X + face.rect.Width), yCoordStartSearchEyes);

                Size searchEyesAreaSize = new Size(face.rect.Width, (face.rect.Height * 2 / 9));
                Size eyeAreaSize = new Size(face.rect.Width / 2, (face.rect.Height * 2 / 9));
                System.Drawing.Point lowerEyesPointOptimized = new System.Drawing.Point(face.rect.X, yCoordStartSearchEyes + searchEyesAreaSize.Height);
                System.Drawing.Point startingLeftEyePointOptimized = new System.Drawing.Point(face.rect.X + face.rect.Width / 2, yCoordStartSearchEyes);

                Rectangle leftEyeArea = new Rectangle(new System.Drawing.Point(startingPointSearchEyes.X + 25, startingPointSearchEyes.Y + 10),
                                                     new Size(eyeAreaSize.Width - 25, eyeAreaSize.Height - 20));
                Rectangle rightEyeArea = new Rectangle(new System.Drawing.Point(startingLeftEyePointOptimized.X + 5, startingLeftEyePointOptimized.Y + 10),
                                                     new Size(eyeAreaSize.Width - 33, eyeAreaSize.Height - 20));
                #endregion

                //#region 눈 영역 그리기
                //a = new LineSegment2D(startingPointSearchEyes, endingPointSearchEyes);
                //b = new LineSegment2D(new System.Drawing.Point(lowerEyesPointOptimized.X, lowerEyesPointOptimized.Y),
                //                      new System.Drawing.Point((lowerEyesPointOptimized.X + face.rect.Width), (yCoordStartSearchEyes + searchEyesAreaSize.Height)));
                //d = new Bgr(Color.Chocolate);

                ////그리기
                //frame.Draw(a, d, 3);
                //frame.Draw(b, d, 3);
                //#endregion

                #region 눈 영역 검출한 Rectangle의 크기가 양수일 경우에만 눈 영역 적출하기
                if (leftEyeArea.Width > 0 && leftEyeArea.Height > 0 && rightEyeArea.Width > 0 && rightEyeArea.Height > 0)
                {
                    possibleROI_leftEye = leftEyeArea;
                    possibleROI_rightEye = rightEyeArea;
                }
                #endregion 
            }// if(faceDetect[0])
        }

        // Progress 리포트 - UI Thread
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }

        // 작업 완료 - UI Thread
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            thresholdValueText.Text = TV.ToString();
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
    }
}
