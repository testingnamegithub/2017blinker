namespace BlinkBlink_EyeJoah.FacebookLogin
{
    using System;
    using System.Windows.Forms;
    using Facebook;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    public partial class FB_Analyze : Form
    {
        private const string AppId = "842840515831167";
        private const string ExtendedPermissions = "user_about_me,user_posts";
        private string _accessToken;
        private List<String> userInfo;
        private GetFacebookUserData getFacebookUserData;
        private Form trainingFaceForm;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern bool HideCaret(IntPtr hWnd);

        #region 마우스로 Form 이동에 관한 변수
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        #endregion


        // 가장자리 둥글게
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public FB_Analyze()
        {
            InitializeComponent();

            // Form 가장자리 둥글게 만들기
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        public FB_Analyze(Form trainingFaceForm)
        {
            InitializeComponent();

            // Form 가장자리 둥글게 만들기
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            this.trainingFaceForm = trainingFaceForm;
        }


        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    userInfo = new List<String>();
                    getFacebookUserData = new GetFacebookUserData(fb);
                    getFacebookUserData.InitUserProfile();
                    userInfo = getFacebookUserData.getUserInfo;

                    startMainForm(Constant.FacebookLogin);
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        private void startMainForm(int Mode)
        {
            // Form들 숨기고 Timer Stop 시키기
            this.Hide();
            //this.trainingFaceForm.Hide();
            //FaceTraining.timer.Stop();

            // MainForm 띄우기 
            Form1 mainForm;
            if (Mode.Equals(Constant.FacebookLogin))
            {
                mainForm = new Form1(this,userInfo, _accessToken);
            }
            else
            {
                mainForm = new Form1(trainingFaceForm);
            }
            mainForm.Show();
            mainForm.Activate();
            EyeBlinkDetection.stopIdle = false;
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            // 인터넷 연결 됬는지 확인
            CheckInternetConnection checkInternetConnection = CheckInternetConnection.GetInstance();

            // 인터넷 연결이 되었을 경우
            if(checkInternetConnection.CheckForConnection())
            {
                var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
                fbLoginDialog.ShowDialog();

                DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);

            }
            // 안 되있을 경우 
            else
            {
                MessageBox.Show("User data visualization service is not available because internet isn't connected.");
                startMainForm(Constant.USUALLOGIN);
            }
        }

        
        // 비밀번호 변환
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //FaceTraining.timer.Start();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            FaceTraining faceTrainingForm = new FaceTraining(this);
            faceTrainingForm.TopMost = true;
            faceTrainingForm.Show();
            faceTrainingForm.Activate();
            
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Panel panelName = (Panel)sender;
            switch (panelName.Name)
            {
                case "facebookLoginBtn":
                    panelName.BackgroundImage = Properties.Resources.login_with_facebook_hover;
                    break;
                case "LoginBtn":
                    panelName.BackgroundImage = Properties.Resources.LoginButton_hover;
                            break;
            }
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Panel panelName = (Panel)sender;
            switch (panelName.Name)
            {
                case "facebookLoginBtn":
                    panelName.BackgroundImage = Properties.Resources.login_with_facebook;
                    break;
                case "LoginBtn":
                    panelName.BackgroundImage = Properties.Resources.LoginButton;
                    break;
            }
         
        }
        
    }
}
