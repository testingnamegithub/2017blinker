namespace BlinkBlink_EyeJoah
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.tempProfile = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.back_settings = new System.Windows.Forms.Panel();
            this.picturebox_Setting = new System.Windows.Forms.PictureBox();
            this.workPanel = new System.Windows.Forms.Panel();
            this.workLabel = new System.Windows.Forms.Label();
            this.back_work = new System.Windows.Forms.Panel();
            this.picturebox_Work = new System.Windows.Forms.PictureBox();
            this.pinkLine1 = new System.Windows.Forms.Panel();
            this.blinkPanel = new System.Windows.Forms.Panel();
            this.blinkLabel = new System.Windows.Forms.Label();
            this.back_blink = new System.Windows.Forms.Panel();
            this.picturebox_BlinkStaticis = new System.Windows.Forms.PictureBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.back_home = new System.Windows.Forms.Panel();
            this.picturebox_Home = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.tempLogo = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.eyeBlinkText = new System.Windows.Forms.Label();
            this.eyeBlinkNumText = new System.Windows.Forms.Label();
            this.rightEyeImageBox = new Emgu.CV.UI.ImageBox();
            this.leftEyeImageBox = new Emgu.CV.UI.ImageBox();
            this.imageBoxCapturedFrame = new Emgu.CV.UI.ImageBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempProfile)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.back_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Setting)).BeginInit();
            this.workPanel.SuspendLayout();
            this.back_work.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Work)).BeginInit();
            this.blinkPanel.SuspendLayout();
            this.back_blink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_BlinkStaticis)).BeginInit();
            this.homePanel.SuspendLayout();
            this.back_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Home)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempLogo)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEyeImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftEyeImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCapturedFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Silver;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.header);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(184, 409);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.panel1.Controls.Add(this.profilePanel);
            this.panel1.Controls.Add(this.settingsPanel);
            this.panel1.Controls.Add(this.workPanel);
            this.panel1.Controls.Add(this.pinkLine1);
            this.panel1.Controls.Add(this.blinkPanel);
            this.panel1.Controls.Add(this.homePanel);
            this.panel1.Location = new System.Drawing.Point(2, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 367);
            this.panel1.TabIndex = 0;
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.Color.White;
            this.profilePanel.Controls.Add(this.tempProfile);
            this.profilePanel.Controls.Add(this.UserNameLabel);
            this.profilePanel.Location = new System.Drawing.Point(0, 0);
            this.profilePanel.Margin = new System.Windows.Forms.Padding(2);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(180, 67);
            this.profilePanel.TabIndex = 50;
            // 
            // tempProfile
            // 
            this.tempProfile.Image = ((System.Drawing.Image)(resources.GetObject("tempProfile.Image")));
            this.tempProfile.Location = new System.Drawing.Point(10, 15);
            this.tempProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tempProfile.Name = "tempProfile";
            this.tempProfile.Size = new System.Drawing.Size(43, 40);
            this.tempProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tempProfile.TabIndex = 0;
            this.tempProfile.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UserNameLabel.ForeColor = System.Drawing.Color.Black;
            this.UserNameLabel.Location = new System.Drawing.Point(59, 27);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(84, 18);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "User Name";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Controls.Add(this.back_settings);
            this.settingsPanel.Location = new System.Drawing.Point(0, 229);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(180, 44);
            this.settingsPanel.TabIndex = 52;
            this.settingsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton4_Click);
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.settingsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsLabel.Location = new System.Drawing.Point(49, 13);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(59, 17);
            this.settingsLabel.TabIndex = 52;
            this.settingsLabel.Text = "Settings";
            this.settingsLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton4_Click);
            // 
            // back_settings
            // 
            this.back_settings.BackColor = System.Drawing.Color.Transparent;
            this.back_settings.Controls.Add(this.picturebox_Setting);
            this.back_settings.Location = new System.Drawing.Point(3, 0);
            this.back_settings.Name = "back_settings";
            this.back_settings.Size = new System.Drawing.Size(42, 47);
            this.back_settings.TabIndex = 52;
            // 
            // picturebox_Setting
            // 
            this.picturebox_Setting.Image = global::BlinkBlink_EyeJoah.Properties.Resources.settingsLogo2;
            this.picturebox_Setting.Location = new System.Drawing.Point(10, 8);
            this.picturebox_Setting.Name = "picturebox_Setting";
            this.picturebox_Setting.Size = new System.Drawing.Size(28, 27);
            this.picturebox_Setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Setting.TabIndex = 49;
            this.picturebox_Setting.TabStop = false;
            this.picturebox_Setting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton4_Click);
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.workPanel.Controls.Add(this.workLabel);
            this.workPanel.Controls.Add(this.back_work);
            this.workPanel.Location = new System.Drawing.Point(0, 177);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(180, 44);
            this.workPanel.TabIndex = 51;
            this.workPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton3_Click);
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.workLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workLabel.Location = new System.Drawing.Point(49, 13);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(41, 17);
            this.workLabel.TabIndex = 4;
            this.workLabel.Text = "Work";
            this.workLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton3_Click);
            // 
            // back_work
            // 
            this.back_work.BackColor = System.Drawing.Color.Transparent;
            this.back_work.Controls.Add(this.picturebox_Work);
            this.back_work.Location = new System.Drawing.Point(4, 0);
            this.back_work.Name = "back_work";
            this.back_work.Size = new System.Drawing.Size(42, 47);
            this.back_work.TabIndex = 51;
            // 
            // picturebox_Work
            // 
            this.picturebox_Work.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_Work.Image = global::BlinkBlink_EyeJoah.Properties.Resources.workLogo2;
            this.picturebox_Work.Location = new System.Drawing.Point(10, 8);
            this.picturebox_Work.Name = "picturebox_Work";
            this.picturebox_Work.Size = new System.Drawing.Size(28, 27);
            this.picturebox_Work.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Work.TabIndex = 0;
            this.picturebox_Work.TabStop = false;
            this.picturebox_Work.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton3_Click);
            // 
            // pinkLine1
            // 
            this.pinkLine1.BackColor = System.Drawing.Color.Silver;
            this.pinkLine1.Location = new System.Drawing.Point(0, 67);
            this.pinkLine1.Margin = new System.Windows.Forms.Padding(2);
            this.pinkLine1.Name = "pinkLine1";
            this.pinkLine1.Size = new System.Drawing.Size(180, 7);
            this.pinkLine1.TabIndex = 2;
            // 
            // blinkPanel
            // 
            this.blinkPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.blinkPanel.Controls.Add(this.blinkLabel);
            this.blinkPanel.Controls.Add(this.back_blink);
            this.blinkPanel.Location = new System.Drawing.Point(0, 125);
            this.blinkPanel.Name = "blinkPanel";
            this.blinkPanel.Size = new System.Drawing.Size(180, 44);
            this.blinkPanel.TabIndex = 50;
            this.blinkPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_Click);
            // 
            // blinkLabel
            // 
            this.blinkLabel.AutoSize = true;
            this.blinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.blinkLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blinkLabel.Location = new System.Drawing.Point(49, 13);
            this.blinkLabel.Name = "blinkLabel";
            this.blinkLabel.Size = new System.Drawing.Size(38, 17);
            this.blinkLabel.TabIndex = 3;
            this.blinkLabel.Text = "Blink";
            this.blinkLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_Click);
            // 
            // back_blink
            // 
            this.back_blink.BackColor = System.Drawing.Color.Transparent;
            this.back_blink.Controls.Add(this.picturebox_BlinkStaticis);
            this.back_blink.Location = new System.Drawing.Point(3, 0);
            this.back_blink.Name = "back_blink";
            this.back_blink.Size = new System.Drawing.Size(42, 47);
            this.back_blink.TabIndex = 50;
            // 
            // picturebox_BlinkStaticis
            // 
            this.picturebox_BlinkStaticis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_BlinkStaticis.Image = global::BlinkBlink_EyeJoah.Properties.Resources.blinkLogo2;
            this.picturebox_BlinkStaticis.Location = new System.Drawing.Point(10, 8);
            this.picturebox_BlinkStaticis.Name = "picturebox_BlinkStaticis";
            this.picturebox_BlinkStaticis.Size = new System.Drawing.Size(28, 27);
            this.picturebox_BlinkStaticis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_BlinkStaticis.TabIndex = 0;
            this.picturebox_BlinkStaticis.TabStop = false;
            this.picturebox_BlinkStaticis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_Click);
            // 
            // homePanel
            // 
            this.homePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.homePanel.Controls.Add(this.homeLabel);
            this.homePanel.Controls.Add(this.back_home);
            this.homePanel.Location = new System.Drawing.Point(0, 73);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(180, 44);
            this.homePanel.TabIndex = 49;
            this.homePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.homeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.homeLabel.Location = new System.Drawing.Point(49, 13);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(45, 17);
            this.homeLabel.TabIndex = 2;
            this.homeLabel.Text = "Home";
            this.homeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_Click);
            // 
            // back_home
            // 
            this.back_home.BackColor = System.Drawing.Color.Transparent;
            this.back_home.Controls.Add(this.picturebox_Home);
            this.back_home.Location = new System.Drawing.Point(3, 0);
            this.back_home.Name = "back_home";
            this.back_home.Size = new System.Drawing.Size(42, 47);
            this.back_home.TabIndex = 49;
            // 
            // picturebox_Home
            // 
            this.picturebox_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_Home.Image = global::BlinkBlink_EyeJoah.Properties.Resources.houseLogo2;
            this.picturebox_Home.Location = new System.Drawing.Point(10, 8);
            this.picturebox_Home.Name = "picturebox_Home";
            this.picturebox_Home.Size = new System.Drawing.Size(28, 27);
            this.picturebox_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox_Home.TabIndex = 0;
            this.picturebox_Home.TabStop = false;
            this.picturebox_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(170)))));
            this.header.Controls.Add(this.tempLogo);
            this.header.Controls.Add(this.titleLabel);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(182, 40);
            this.header.TabIndex = 1;
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tempLogo
            // 
            this.tempLogo.Image = global::BlinkBlink_EyeJoah.Properties.Resources.blinkerLogo_gradient4;
            this.tempLogo.Location = new System.Drawing.Point(24, 10);
            this.tempLogo.Margin = new System.Windows.Forms.Padding(2);
            this.tempLogo.Name = "tempLogo";
            this.tempLogo.Size = new System.Drawing.Size(21, 20);
            this.tempLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tempLogo.TabIndex = 2;
            this.tempLogo.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(52, 10);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(68, 19);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Blinker";
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.Gray;
            this.panelContainer.Location = new System.Drawing.Point(184, 370);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(607, 37);
            this.panelContainer.TabIndex = 2;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(170)))));
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Location = new System.Drawing.Point(172, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(621, 40);
            this.topPanel.TabIndex = 3;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(546, 8);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 20);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(580, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // eyeBlinkText
            // 
            this.eyeBlinkText.AutoSize = true;
            this.eyeBlinkText.BackColor = System.Drawing.Color.Black;
            this.eyeBlinkText.Font = new System.Drawing.Font("넥슨 풋볼고딕 B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.eyeBlinkText.ForeColor = System.Drawing.Color.Red;
            this.eyeBlinkText.Location = new System.Drawing.Point(475, 211);
            this.eyeBlinkText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eyeBlinkText.Name = "eyeBlinkText";
            this.eyeBlinkText.Size = new System.Drawing.Size(169, 30);
            this.eyeBlinkText.TabIndex = 46;
            this.eyeBlinkText.Text = "눈 깜빡임 횟수 ";
            // 
            // eyeBlinkNumText
            // 
            this.eyeBlinkNumText.AutoSize = true;
            this.eyeBlinkNumText.BackColor = System.Drawing.Color.Black;
            this.eyeBlinkNumText.Font = new System.Drawing.Font("넥슨 풋볼고딕 B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.eyeBlinkNumText.ForeColor = System.Drawing.Color.Red;
            this.eyeBlinkNumText.Location = new System.Drawing.Point(372, 87);
            this.eyeBlinkNumText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eyeBlinkNumText.Name = "eyeBlinkNumText";
            this.eyeBlinkNumText.Size = new System.Drawing.Size(28, 30);
            this.eyeBlinkNumText.TabIndex = 47;
            this.eyeBlinkNumText.Text = "0";
            // 
            // rightEyeImageBox
            // 
            this.rightEyeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightEyeImageBox.Location = new System.Drawing.Point(559, 267);
            this.rightEyeImageBox.Name = "rightEyeImageBox";
            this.rightEyeImageBox.Size = new System.Drawing.Size(92, 64);
            this.rightEyeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightEyeImageBox.TabIndex = 45;
            this.rightEyeImageBox.TabStop = false;
            // 
            // leftEyeImageBox
            // 
            this.leftEyeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftEyeImageBox.Location = new System.Drawing.Point(559, 139);
            this.leftEyeImageBox.Name = "leftEyeImageBox";
            this.leftEyeImageBox.Size = new System.Drawing.Size(92, 61);
            this.leftEyeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftEyeImageBox.TabIndex = 44;
            this.leftEyeImageBox.TabStop = false;
            // 
            // imageBoxCapturedFrame
            // 
            this.imageBoxCapturedFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxCapturedFrame.Location = new System.Drawing.Point(298, 138);
            this.imageBoxCapturedFrame.Margin = new System.Windows.Forms.Padding(2);
            this.imageBoxCapturedFrame.Name = "imageBoxCapturedFrame";
            this.imageBoxCapturedFrame.Size = new System.Drawing.Size(353, 205);
            this.imageBoxCapturedFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxCapturedFrame.TabIndex = 43;
            this.imageBoxCapturedFrame.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(793, 409);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.rightEyeImageBox);
            this.Controls.Add(this.eyeBlinkText);
            this.Controls.Add(this.leftEyeImageBox);
            this.Controls.Add(this.eyeBlinkNumText);
            this.Controls.Add(this.imageBoxCapturedFrame);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "                                     Blink Blink";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempProfile)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.back_settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Setting)).EndInit();
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.back_work.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Work)).EndInit();
            this.blinkPanel.ResumeLayout(false);
            this.blinkPanel.PerformLayout();
            this.back_blink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_BlinkStaticis)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.back_home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Home)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempLogo)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEyeImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftEyeImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCapturedFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.PictureBox tempProfile;
        private System.Windows.Forms.PictureBox tempLogo;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox rightEyeImageBox;
        private System.Windows.Forms.Label eyeBlinkText;
        private Emgu.CV.UI.ImageBox leftEyeImageBox;
        private System.Windows.Forms.Label eyeBlinkNumText;
        private Emgu.CV.UI.ImageBox imageBoxCapturedFrame;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox picturebox_Home;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Panel blinkPanel;
        private System.Windows.Forms.PictureBox picturebox_Work;
        private System.Windows.Forms.PictureBox picturebox_BlinkStaticis;
        private System.Windows.Forms.Panel back_blink;
        private System.Windows.Forms.Panel back_home;
        private System.Windows.Forms.Panel back_settings;
        private System.Windows.Forms.Panel back_work;
        private System.Windows.Forms.PictureBox picturebox_Setting;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label blinkLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Panel pinkLine1;
        private System.Windows.Forms.Panel profilePanel;
    }
}

