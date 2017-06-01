using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BlinkBlink_EyeJoah
{
    public partial class DistanceAlertScreencs : Form
    {
        /* 싱글톤 적용 변수 */
        private static DistanceAlertScreencs instance = null;

        private Point location;
        private Rectangle workingArea;
        private BackgroundWorker worker;

        /* 싱글톤 */
        public static DistanceAlertScreencs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DistanceAlertScreencs();

                }
                return instance;
            }
        }

        public DistanceAlertScreencs()
        {
            // Blink 기능 수행하는 Thread 생성
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            InitializeComponent();

            workingArea = Screen.GetWorkingArea(this);

            this.Location = new Point(workingArea.Right, workingArea.Bottom - Size.Height - 30);
            worker.RunWorkerAsync();
        }

        private void formShow()
        {

        }
        
        // Worker Thread가 실제 하는 일
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            location = new Point(0, 0);
            for (int i = 0; i < 530; i++)
            {
                location = new Point(workingArea.Right - i, workingArea.Bottom - Size.Height - 30);
                try
                {
                    this.Location = location;
                }
                catch (Exception except)
                {

                }

            }
        }

        // Progress 리포트 - UI Thread
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        // 작업 완료 - UI Thread
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }
        // 종료
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
