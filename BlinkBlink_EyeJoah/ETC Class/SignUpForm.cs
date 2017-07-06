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
    public partial class SignUpForm : Form
    {
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

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.ForeColor = Color.Black;
        }

        private void Txtbox_MouseClick(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.Clear();

        }

        private void PasswordTextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.PasswordChar = '*';
            txtBox.ForeColor = Color.Black;
        }

        private new void MouseMove(object sender, MouseEventArgs e)
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
        }

        private void SignInFacebookBtn(object sender, EventArgs e)
        {

        }

        private void MouseEnter(object sender, EventArgs e)
        {
            Panel panelName = (Panel)sender;
            switch (panelName.Name)
            {
                case "facebookLoginBtn":
                    panelName.BackgroundImage = Properties.Resources.login_with_facebook_hover;
                    break;
                //case "LoginBtn":
                //    panelName.BackgroundImage = Properties.Resources.LoginButton_hover;
                //    break;
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Panel panelName = (Panel)sender;
            switch (panelName.Name)
            {
                case "facebookLoginBtn":
                    panelName.BackgroundImage = Properties.Resources.login_with_facebook;
                    break;
                //case "confirmBtn":
                //    panelName.BackgroundImage = Properties.Resources.LoginButton;
                //    break;
            }
        }
    }
}
