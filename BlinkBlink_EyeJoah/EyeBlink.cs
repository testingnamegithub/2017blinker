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
        private Form1 mainForm;

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

        public EyeBlink(Form1 mainForm)
        {
            this.mainForm = mainForm;
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

                    //// Blink 기능 수행하는 Thread 생성
                    //worker = new BackgroundWorker();
                    //worker.WorkerReportsProgress = true;
                    //worker.WorkerSupportsCancellation = true;
                    //worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                    //worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
                    //worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

                }
                catch (NullReferenceException excpt) { }
            }

            // capture가 생성 됐다면 EventHandler 추가 및 실행
            //if (_capture != null)
            //{
            //    Application.Idle += FrameGrabber;
            //}
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            //새로운 Frame 얻은 후 ImageBox에 투영하기
            frame = _capture.QueryFrame();



        }
    }
}