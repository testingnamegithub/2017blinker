using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using Facebook;

namespace BlinkBlink_EyeJoah
{
    public partial class Form1 : Form
    {
        /* 눈 깜빡임 기능을 담당하는 Class */
        private EyeBlinkDetection eyeBlink;
        private Form loginForm;
        private String accessToken;
        private int thresholdValue = 0;

        private Control1_Home control1;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private List<String> facebookLoginUserData;

        //public static Label lb;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public static Form1 mainForm;

        public Form1()
        {
            InitializeComponent();

            Init_UI(Constant.USUALLOGIN);
            Start_Process();
        }

        public Form1(Form trainingFaceForm)
        {
            InitializeComponent();

            //this.trainingFaceForm = trainingFaceForm;

            Init_UI(Constant.USUALLOGIN);
            Start_Process();
        }

        // Facebook을 통해 Login한 경우
        public Form1(Form loginForm, List<String> loginUserData, String _accessToken)
        {
            InitializeComponent();

            this.facebookLoginUserData = loginUserData;
            this.accessToken = _accessToken;
            this.loginForm = loginForm;
            Init_UI(Constant.FacebookLogin);
            Start_Process();
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

        private void Init_UI(int Mode)
        {
            // profile에 User Data 넣어주기 ( 사진 및 이름 )
            if(Mode == Constant.FacebookLogin)
            {
                tempProfile.Load(facebookLoginUserData[2]);
                UserNameLabel.Text = facebookLoginUserData[1];
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.panelContainer.BringToFront();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));


            homePanel.BackColor = Color.FromArgb(45, 187, 167); //기존 컬러
            //back_home.BackColor = Color.FromArgb(39, 168, 150);
            homeLabel.ForeColor = Color.White;

            /* Main화면 띄우기 */
            control1 = new Control1_Home();
            control1.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(control1);
        }

        private void Start_Process()
        {
            mainForm = this;

            /* Eye Blink Detection 감지하는 Class 생성 및 실행 */
            eyeBlink = new EyeBlinkDetection(this.control1, this.imageBoxCapturedFrame, this.leftEyeImageBox,
                                             this.rightEyeImageBox, this.eyeBlinkNumText);
            eyeBlink.start_EyeBlink();
        }

        private void bunifuFlatButton1_Click(object sender, MouseEventArgs e)
        {
            control1.Dock = DockStyle.Fill;
            Control1_Home.blinkTimer.Start();
            panelContainer.Controls.RemoveAt(0);
            panelContainer.Controls.Add(control1);
            EyeBlinkDetection.stopIdle = false;

            homePanel.BackColor = Color.FromArgb(50, 208, 186);
            blinkPanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(218, 253, 247);
            settingsPanel.BackColor = Color.FromArgb(218, 253, 247);
            homeLabel.ForeColor = Color.White;
            blinkLabel.ForeColor = Color.Black;
            workLabel.ForeColor = Color.Black;
            settingsLabel.ForeColor = Color.Black;
        }

        private void bunifuFlatButton2_Click(object sender, MouseEventArgs e)
        {
            Control2_Blinking control2 = new Control2_Blinking();

            Control1_Home.blinkTimer.Stop();
            EyeBlinkDetection.stopIdle = true;
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
        }

        private void bunifuFlatButton3_Click(object sender, MouseEventArgs e)
        {
            Control3_Work control3 = new Control3_Work();

            Control1_Home.blinkTimer.Stop();
            EyeBlinkDetection.stopIdle = true;
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
        }


        private void bunifuFlatButton4_Click(object sender, MouseEventArgs e)
        {
            Control4_Settings control4 = new Control4_Settings();

            Control1_Home.blinkTimer.Stop();
            EyeBlinkDetection.stopIdle = true;
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
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // logout button 눌렀을 경우
        private void logOutText_Click(object sender, EventArgs e)
        {
            // 인터넷 연결이 되어 있을 경우
            CheckInternetConnection checkInternetConnection = CheckInternetConnection.GetInstance();
            if (checkInternetConnection.CheckForConnection().Equals(true))
            {
                var webBrowser = new WebBrowser();
                var fb = new FacebookClient();
                var logouUrl = fb.GetLogoutUrl(new { access_token = accessToken, next = "https://www.facebook.com/connect/login_success.html" });
                webBrowser.Navigate(logouUrl);
            }

            // 현재 MainForm 닫고 FaceTraining Form 다시 실행시키기
            this.Close();
            EyeBlinkDetection.stopIdle = true;
            this.loginForm.Show();
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
            get { return thresholdValue; }
            set { thresholdValue = value; }
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
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            homePanel.BackColor = Color.FromArgb(218, 253, 247);
            blinkPanel.BackColor = Color.FromArgb(218, 253, 247);
            workPanel.BackColor = Color.FromArgb(218, 253, 247);
            settingsPanel.BackColor = Color.FromArgb(218, 253, 247);
        }

        //setting userName
        public void SetUserName(string name)
        {
            UserNameLabel.Text = name;
        }
        //getting userName
        public string GetUserName()
        {
            return UserNameLabel.Text;
        }

    }
}
