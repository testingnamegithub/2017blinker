namespace BlinkBlink_EyeJoah.FacebookLogin
{
    using System;
    using System.Windows.Forms;
    using Facebook;

    public partial class FB_Analyze : Form
    {
        private const string AppId = "842840515831167";
        private const string ExtendedPermissions = "user_about_me,user_posts";
        private string _accessToken;
        private GetFacebookUserData getFacebookUserData;

        public FB_Analyze()
        {
            InitializeComponent();

        }


        private void DisplayAppropriateMessage(FacebookOAuthResult facebookOAuthResult)
        {
            if (facebookOAuthResult != null)
            {
                if (facebookOAuthResult.IsSuccess)
                {
                    _accessToken = facebookOAuthResult.AccessToken;
                    var fb = new FacebookClient(facebookOAuthResult.AccessToken);

                    getFacebookUserData = new GetFacebookUserData(fb);
                    getFacebookUserData.InitUserProfile();

                    //btnLogout.Visible = true;
                }
                else
                {
                    MessageBox.Show(facebookOAuthResult.ErrorDescription);
                }
            }
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
        {
            var fbLoginDialog = new FB_LoginDialog(AppId, ExtendedPermissions);
            fbLoginDialog.ShowDialog();

            DisplayAppropriateMessage(fbLoginDialog.FacebookOAuthResult);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            //var webBrowser = new WebBrowser();
            //var fb = new FacebookClient();
            //var logouUrl = fb.GetLogoutUrl(new { access_token = _accessToken, next = "https://www.facebook.com/connect/login_success.html" });
            //webBrowser.Navigate(logouUrl);
            //btnLogout.Visible = false;

        }
        


        // 비밀번호 변환
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }
        

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
