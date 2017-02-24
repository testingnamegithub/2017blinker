using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;

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

            init_UI();
            
            /* Main화면 띄우기 */
            control1 = new UserControl1();
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control1);

            /* Eye Blink Detection 감지하는 Class 생성 및 실행 */
            eyeBlink = new EyeBlinkDetection(this.control1, this.imageBoxCapturedFrame, this.leftEyeImageBox, 
                                             this.rightEyeImageBox, this.thresholdValueText, this.eyeBlinkNumText);
            eyeBlink.start_EyeBlink();

            homePanel.BackColor = Color.FromArgb(50, 208, 186);
            //back_home.BackColor = Color.FromArgb(39, 168, 150);
            homeLabel.ForeColor = Color.White;
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

        private void init_UI()
        {
            //Bitmap homeImage = Properties.Resources.house_outline;
            //homeImage = ResizeImage.adjust(homeImage, new Size(28, 25));
            //picturebox_Home.Image = homeImage;
            //picturebox_Home.SizeMode = PictureBoxSizeMode.CenterImage;

            //picturebox_BlinkStaticis.Image = Properties.Resources.almond_eyed;
            //picturebox_BlinkStaticis.SizeMode = PictureBoxSizeMode.CenterImage;

            //Bitmap screenImage = Properties.Resources.screen;
            //screenImage = ResizeImage.adjust(screenImage, new Size(26, 25));
            //picturebox_Work.Image = screenImage;
            //picturebox_Work.SizeMode = PictureBoxSizeMode.CenterImage;

            //Bitmap settingImage = Properties.Resources.settings;
            //settingImage = ResizeImage.adjust(settingImage, new Size(27, 27));
            //picturebox_Setting.Image = settingImage;
            //picturebox_Setting.SizeMode = PictureBoxSizeMode.CenterImage;


            //this.label1.Text = File.ReadAllText(Application.StartupPath + "/TrainedFaces/UserName.txt");
            this.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.BringToFront();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void bunifuFlatButton1_Click(object sender, MouseEventArgs e)
        {
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control1);

            homePanel.BackColor = Color.FromArgb(50, 208, 186); 
            blinkPanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(218, 253, 247);
            settingsPanel.BackColor = Color.FromArgb(218, 253, 247);
            homeLabel.ForeColor = Color.White;
            blinkLabel.ForeColor = Color.Black;
            workLabel.ForeColor = Color.Black;
            settingsLabel.ForeColor = Color.Black;
            //back_home.BackColor = Color.FromArgb(39, 168, 150);
            //back_settings.BackColor = Color.FromArgb(46, 200, 178);
            //back_work.BackColor = Color.FromArgb(46, 200, 178);
            //back_blink.BackColor = Color.FromArgb(46, 200, 178);
        }

        private void bunifuFlatButton2_Click(object sender, MouseEventArgs e)
        {
            UserControl2 control2 = new UserControl2();

            control2.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control2);
            blinkPanel.BackColor = Color.FromArgb(50, 208, 186);
            homePanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(218, 253, 247);
            settingsPanel.BackColor = Color.FromArgb(218, 253, 247);
            blinkLabel.ForeColor = Color.White;
            settingsLabel.ForeColor = Color.Black;
            workLabel.ForeColor = Color.Black;
            homeLabel.ForeColor = Color.Black;
            //back_blink.BackColor = Color.FromArgb(39, 168, 150);
            //back_home.BackColor = Color.FromArgb(46, 200, 178);
            //back_settings.BackColor = Color.FromArgb(46, 200, 178);
            //back_work.BackColor = Color.FromArgb(46, 200, 178);
        }

        private void bunifuFlatButton3_Click(object sender, MouseEventArgs e)
        {
            UserControl3 control3 = new UserControl3();

            control3.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control3);
            //new SectionExample().ShowDialog();

            blinkPanel.BackColor = Color.FromArgb(218, 253, 247);
            homePanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(50, 208, 186);
            settingsPanel.BackColor = Color.FromArgb(218, 253, 247);
            workLabel.ForeColor = Color.White;
            blinkLabel.ForeColor = Color.Black;
            homeLabel.ForeColor = Color.Black;
            settingsLabel.ForeColor = Color.Black;
            //back_work.BackColor = Color.FromArgb(39, 168, 150);
            //back_blink.BackColor = Color.FromArgb(46, 200, 178);
            //back_home.BackColor = Color.FromArgb(46, 200, 178);
            //back_settings.BackColor = Color.FromArgb(46, 200, 178);
        }


        private void bunifuFlatButton4_Click(object sender, MouseEventArgs e)
        {
            UserControl4 control4 = new UserControl4();

            control4.Dock = DockStyle.Fill;
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control4);

            blinkPanel.BackColor = Color.FromArgb(218, 253, 247);
            homePanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(218, 253, 247);
            settingsPanel.BackColor = Color.FromArgb(50, 208, 186);
            settingsLabel.ForeColor = Color.White;
            blinkLabel.ForeColor = Color.Black;
            workLabel.ForeColor = Color.Black;
            homeLabel.ForeColor = Color.Black;
            //back_settings.BackColor = Color.FromArgb(39, 168, 150);
            //back_blink.BackColor = Color.FromArgb(46, 200, 178);
            //back_work.BackColor = Color.FromArgb(46, 200, 178);
            //back_home.BackColor = Color.FromArgb(46, 200, 178);
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
            Application.ExitThread();
            Environment.Exit(0);
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










        // 왼쪽 메뉴바 panel, label, picturebox 위에 마우스가 올라갔을 시 해당 Panel 색상 변경 
        private void MouseHover(object sender, EventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case "Panel":
                    Panel panelName = (Panel)sender;
                    switch (panelName.Name)
                    {
                        case "homePanel": homePanel.BackColor = Color.FromArgb(50, 208, 186); break;
                        case "blinkPanel": blinkPanel.BackColor = Color.FromArgb(50, 208, 186); break;
                        case "workPanel": workPanel.BackColor = Color.FromArgb(50, 208, 186); break;
                        case "settingsPanel": settingsPanel.BackColor = Color.FromArgb(50, 208, 186); break;
                    }
                    break;
                //case "PictureBox":
                //    PictureBox pictureboxName = (PictureBox)sender;
                //    switch (pictureboxName.Name)
                //    {
                //        case "picturebox_Home": homePanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //        case "picturebox_BlinkStaticis": blinkPanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //        case "picturebox_Work": workPanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //        case "picturebox_Setting": settingsPanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //    }
                //    break;
                //case "Label":
                //    Label labelName = (Label)sender;
                //    switch (labelName.Name)
                //    {
                //        case "label2": homePanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //        case "label3": blinkPanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //        case "label4": workPanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //        case "label5": settingsPanel.BackColor = Color.FromArgb(29, 188, 170); break;
                //    }
                //    break;
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.FromArgb(218, 253, 247);
            blinkPanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(218, 253, 247);
            settingsPanel.BackColor = Color.FromArgb(218, 253, 247);
        }


    }
}
