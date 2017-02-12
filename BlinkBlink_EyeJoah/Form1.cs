using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BlinkBlink_EyeJoah
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private EyeBlink eyeBlink;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
          
            InitializeComponent();

            /* Eye Blink Detection 감지하는 Class 생성 및 실행 */
            eyeBlink = new EyeBlink(this.imageBoxCapturedFrame, this.leftEyeImageBox, this.rightEyeImageBox, this.thresholdValueText, this.eyeBlinkNumText);
            eyeBlink.start_EyeBlink();
            
            UserControl1 control1 = new UserControl1();
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control1);

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //프로그램 종료
            Application.Exit();
        }

        //private void switchControl(Control removeControl, Control addControl)
        //{
        //    removeControl.Dock = DockStyle.Fill;
        //    panelContainer.Controls.Remove(removeControl);
        //    panelContainer.Controls.Add(addControl);
        //}
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Home";
            UserControl1 control1 = new UserControl1();
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control1);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Blinking";
            UserControl2 control2 = new UserControl2();

            control2.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control2);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Work";
            UserControl3 control3 = new UserControl3();

            control3.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control3);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Settings";
            UserControl4 control4 = new UserControl4();

            control4.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control4);
        }
       
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /* MainForm UI  get_set 함수*/
        public Emgu.CV.UI.ImageBox get_set_imageBoxCapturedFrame
        {
            get { return this.imageBoxCapturedFrame; }
            set { this.imageBoxCapturedFrame = value; }
        }
        public Emgu.CV.UI.ImageBox get_set_leftEyeImageBox
        {
            get { return this.leftEyeImageBox; }
            set { this.leftEyeImageBox = value; }
        }
        public Emgu.CV.UI.ImageBox get_set_rightEyeImageBox
        {
            get { return this.rightEyeImageBox; }
            set { this.rightEyeImageBox = value; }
        }
        public Label get_set_ThresholdValue
        {
            get { return this.thresholdValueText; }
            set { this.thresholdValueText = value; }
        }
        public Label get_set_EyeBlinkNum
        {
            get { return this.eyeBlinkNumText; }
            set { this.eyeBlinkNumText = value; }
        }

    }
}
