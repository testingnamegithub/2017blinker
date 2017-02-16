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
using BlinkBlink_EyeJoah.Chart.Section;

namespace BlinkBlink_EyeJoah
{
    public partial class Form1 : Form
    {
        /* 눈 깜빡임 기능을 담당하는 Class */
        private EyeBlinkDetection eyeBlink;
        private int thresholdValue = 0;

        private UserControl1 control1;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //public static Label lb;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();

            //lb = label2;
            this.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.BringToFront();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            /* Main화면 띄우기 */
            control1 = new UserControl1();
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control1);

            /* Eye Blink Detection 감지하는 Class 생성 및 실행 */
            eyeBlink = new EyeBlinkDetection(this.control1, this.imageBoxCapturedFrame, this.leftEyeImageBox, 
                                             this.rightEyeImageBox, this.thresholdValueText, this.eyeBlinkNumText);
            eyeBlink.start_EyeBlink();
        }

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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Home";
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control1);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Blinking";
            UserControl2 control2 = new UserControl2();

            //control2.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control2);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Work";
            UserControl3 control3 = new UserControl3();

            //control3.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control3);
            //new SectionExample().ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            menuLabel.Text = "Settings";
            UserControl4 control4 = new UserControl4();

            //control4.Dock = DockStyle.Fill;
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

        //프로그램 종료
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //프로그램 최소화
        private void minimizeBtn_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Continuos Graph 값을 넣기 위한 Threshold getset method 
        private int getsetThresholdValue
        {
            get{ return thresholdValue ; }
            set{ thresholdValue = value; }
        }

        //private void switchControl(Control removeControl, Control addControl)
        //{
        //    removeControl.Dock = DockStyle.Fill;
        //    panelContainer.Controls.Remove(removeControl);
        //    panelContainer.Controls.Add(addControl);
        //}
    }
}
