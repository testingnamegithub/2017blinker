
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
using BlinkBlink_EyeJoah.Chart.ConstantChange;


namespace BlinkBlink_EyeJoah
{
    class EyeBlinkDetection
    {
        /* Form1 UI 함수 */
        private Form1 mainForm;
        private Emgu.CV.UI.ImageBox imageBoxCapturedFrame, leftEyeImageBox, rightEyeImageBox;
        private Label thresholdValueText, eyeBlinkNumText;

        private TrainingData trainingData;

        private Capture _capture;                                     // WebCam 작동 시키는 변수 + (Frame 뿌려주기)
        private Image<Bgr, Byte> frame;                               // 현재 Frame 담는 변수
        private HaarCascade _faces;
        private MCvAvgComp face;                                      // Face 검출한 결과를 담고 있는 변수
        private Bitmap Thimage;                                       // Face 검출된 이미지를 저장한 Bitmap변수 - Threshold 적용을 위한 사진(Bitmap)
        private Rectangle possibleROI_rightEye, possibleROI_leftEye;  // 눈 영역을 담고 있는 Rect

        private BackgroundWorker worker;        // 얼굴 검출 및 눈 깜빡임 기능을 하는 Thread 변수
        public static int TV = 0;               // TV = Label에 현재 Threshold값 띄어주기 위해 저장하는 변수

        private int blurAmount = 1;             // 블러값 = 1
        private int thresholdValue = 30;        // Threshold 초기값 = 30
        private int prevThresholdValue = 0;
        private int blinkNum = 0;               // 눈 깜빡임 횟수담는 변수

        private List<int> averageThresholdValue;
        private Boolean detectedUser = false;           // 감지된 얼굴이 등록되어진 User일 경우를 확인하는 변수
        public static Boolean catchBlackPixel = false;  // Black Pixel을 발견했다 안했다를 알려주는 변수
        public static Boolean catchBlink = false;       // Blink 감지를 위한 변수

        /* ContantChange 그래프에 관련된 변수 */
        private UserControl1 control1;
        private ConstantChange con;

        /* constructor(생성자) */
        public EyeBlinkDetection(UserControl1 control1, Emgu.CV.UI.ImageBox imageBoxCapturedFrame,
                        Emgu.CV.UI.ImageBox leftEyeImageBox, Emgu.CV.UI.ImageBox rightEyeImageBox,
                        Label thresholdValue, Label eyeBlinkNum)
        {
            this.control1 = control1;
            this.imageBoxCapturedFrame = imageBoxCapturedFrame;
            this.leftEyeImageBox = leftEyeImageBox;
            this.rightEyeImageBox = rightEyeImageBox;
            this.thresholdValueText = thresholdValue;
            this.eyeBlinkNumText = eyeBlinkNum;
        }

        public void start_EyeBlink()
        {
            // constantChange Graph 참조하기
            con = control1.getConstantChange;
            // TrainingData 참조하기
            trainingData = TrainingData.Instance;
            // trainingImage에 관한 Data Load하기
            trainingData.loadTrainingData();

            // capture 생성
            if (_capture == null)
            {
                try
                {
                    _capture = new Capture();
                    _faces = new HaarCascade("haarcascade_frontalface_default.xml");

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
                // 일종의 EventHandler ( 일정시간 마다 FrameGrabber 실행시키기 )
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
                frame.Draw(face.rect, new Bgr(Color.Red), 2);
                if (face.rect.Width > 300)
                {
                    MessageBox.Show("모니터와 사이가 넓습니다 거리를 유지시켜주세요");
                }
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
                    EyeBlinkDetection.catchBlackPixel = false;
                    thresholdEffect(thresholdValue);
                }
                catch (ArgumentException expt) { }
            }
            #endregion
        }//FrameGrapper


        // Worker Thread가 실제 하는 일
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Image<Gray, Byte> grayFrame = (Image<Gray, Byte>)e.Argument;
            detectedUser = false;

            // 머신러닝을 이용한 얼굴 인식 Haaracascade 돌리기
            MCvAvgComp[][] facesDetected = grayFrame.DetectHaarCascade(_faces, 1.1, 0, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, new Size(20, 20));
            //Detect한 얼굴들(elements) 작업
            foreach (MCvAvgComp detectedface in facesDetected[0])
            {
                // result 변수에 현재 잡힌 얼굴 저장.(얼굴 training 등록할 때 쓰임 )
                Image<Gray, byte> result = frame.Copy(detectedface.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
  
                //잡힌 얼굴 비교하기 ( Training안에 있는 이미지를 통해 )
                if (trainingData.getset_TrainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(trainingData.getset_CountTrain, 0.001);
                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingData.getset_TrainingImages.ToArray(),
                                                                                 trainingData.getset_trainedNamesList.ToArray(), 3000, ref termCrit);
                    //해당 검출한 Face의 이름 찾기 작업 수행
                    String userName = recognizer.Recognize(result);
                    //검출된 Face의 이름이 User와 같다면 face 변수에 해당 얼굴로 저장.
                    if(userName.Equals(File.ReadAllText(Application.StartupPath + "/TrainedFaces/UserName.txt")))
                    {
                        face = detectedface;
                        detectedUser = true;
                    }
                    //해당 얼굴 없으면 continue
                    else
                    {
                        continue;
                    }

                    // frame안 Detect된 User 얼굴 위에 이름 써주기
                    frame.Draw(userName, ref FaceTraining.font, new System.Drawing.Point(detectedface.rect.X - 2, detectedface.rect.Y - 2), new Bgr(Color.LightGreen));
                }
                // 만약 Detect된 얼굴들 중 하나도 User와 매칭이 되지 않았을 경우 
                // face 변수는 가장 먼저 인식된 얼굴로 저장
                if (detectedUser.Equals(false))
                {
                    face = facesDetected[0][0];
                }
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

            // constantGraph에 현재 Threshold값 넘겨주기
            con.ShowThresholdValue(TV);
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

        #region 눈 검출 방법 : 눈 떳을 때, 눈 감았을 때의 threshold 값의 변화에 따라 눈 깜빡임 인식
        public void thresholdEffect(int catchThreshold)
        {
            // Black 픽셀이 잡힌 경우 재귀 함수 빠져나가기
            if (EyeBlinkDetection.catchBlackPixel.Equals(true))
            {
                return;
            }

            // 눈 깜빡임을 검출할 눈 영역 Median Blur 필터 적용
            Thimage = (Bitmap)rightEyeImageBox.Image.Bitmap;
            Median filter = new Median();
            filter.ApplyInPlace(Thimage);

            // 눈 깜빡임을 검출할 눈 영역 Threshold 필터 적용 - (catchThreshold 값으로)
            IFilter threshold = new Threshold(catchThreshold);
            Thimage = Grayscale.CommonAlgorithms.RMY.Apply(Thimage);
            Thimage = threshold.Apply(Thimage);

            // 눈 검출할 영역의 가로 길이가 50mm가 넘는다면 40x30 size로 변환
            // (카메라 가까이에 얼굴이 있으면 눈 영역도 커지기 때문에 계산량 일정하게 만들기) 
            if (Thimage.Width > 50)
                Thimage = ResizeImage(Thimage, new Size(40, 30));

            // 필터링 된 이미지 blur 처리 후 한 픽셀이라도 검은 Pixel이 존재한 다면 
            // catchBlackPixel = true로 변경.
            for (int x = blurAmount + 5; x <= Thimage.Width - blurAmount; x++)
            {
                for (int y = blurAmount + 5; y <= Thimage.Height - blurAmount; y++)
                {
                    try
                    {
                        Color prevX = Thimage.GetPixel(x - blurAmount, y);
                        Color nextX = Thimage.GetPixel(x + blurAmount, y);
                        Color prevY = Thimage.GetPixel(x, y - blurAmount);
                        Color nextY = Thimage.GetPixel(x, y + blurAmount);

                        int avgR = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        if (avgR < 150)
                        {
                            EyeBlinkDetection.catchBlackPixel = true;
                            break;
                        }
                    }
                    catch (Exception) { }
                }
            }

            // 검은 Pixel 존재 할 경우
            if (EyeBlinkDetection.catchBlackPixel.Equals(true))
            {
                // Tresholdvalue =  Label에 투영시킬 변수 
                TV = catchThreshold;

                // 이 동작을 3번 ㅇ
                if (averageThresholdValue.Count > 3)
                {
                    averageThresholdValue.Add((averageThresholdValue[1] + averageThresholdValue[2]) / 2);
                    Double doubleValue = averageThresholdValue.Average() - averageThresholdValue.Average() % 10;
                    int a = (int)doubleValue;
                    thresholdValue = a - 5;
                }
                else
                {
                    averageThresholdValue.Add(catchThreshold);
                }

                // catchThreshold와 평균 Threshold값을 비교하여 눈 깜빡임 detect
                // 만약 직전에도 이 값일 경우엔 Pass 
                if (catchThreshold > averageThresholdValue.Average() + 9 &&
                    catchThreshold < averageThresholdValue.Average() + 25)
                {
                    if (!catchBlink)
                    {
                        blinkNum++;
                        catchBlink = true;
                        eyeBlinkNumText.Text = blinkNum.ToString();
                    }
                    else
                    {
                        catchBlink = true;
                    }

                }
                else
                {
                    catchBlink = false;
                }

                //label2.Text = ((double)prevThresholdValue / (double)catchThreshold).ToString();
                return;
            }
            // 만약 해당 이미지에 검은 픽셀이 존재하지 않을경우 
            // catchThreshold값을 1 증가시켜 재귀 함수를 통해 다시 계산시키기
            else
            {
                if (catchThreshold < 120)
                {
                    catchThreshold += 1;
                    prevThresholdValue = catchThreshold;
                    thresholdEffect(catchThreshold);
                }
            }
        }
        #endregion
    }
}
