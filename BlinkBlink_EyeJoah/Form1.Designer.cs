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
            this.selectCamera = new System.Windows.Forms.ComboBox();
            this.teamLabel = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tempProfile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.tempLogo = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rightEyeImageBox = new Emgu.CV.UI.ImageBox();
            this.thresholdValueText = new System.Windows.Forms.Label();
            this.eyeBlinkText = new System.Windows.Forms.Label();
            this.leftEyeImageBox = new Emgu.CV.UI.ImageBox();
            this.eyeBlinkNumText = new System.Windows.Forms.Label();
            this.imageBoxCapturedFrame = new Emgu.CV.UI.ImageBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempProfile)).BeginInit();
            this.panelContainer.SuspendLayout();
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
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(179)))), ((int)(((byte)(158)))));
            this.sidebar.Controls.Add(this.selectCamera);
            this.sidebar.Controls.Add(this.teamLabel);
            this.sidebar.Controls.Add(this.bunifuFlatButton4);
            this.sidebar.Controls.Add(this.bunifuFlatButton3);
            this.sidebar.Controls.Add(this.bunifuFlatButton2);
            this.sidebar.Controls.Add(this.bunifuFlatButton1);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(199, 478);
            this.sidebar.TabIndex = 0;
            // 
            // selectCamera
            // 
            this.selectCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCamera.Font = new System.Drawing.Font("굴림", 11F);
            this.selectCamera.FormattingEnabled = true;
            this.selectCamera.Items.AddRange(new object[] {
            "노트북 내장 카메라",
            "외장 카메라",
            "휴대폰 카메라"});
            this.selectCamera.Location = new System.Drawing.Point(22, 154);
            this.selectCamera.Margin = new System.Windows.Forms.Padding(2);
            this.selectCamera.Name = "selectCamera";
            this.selectCamera.Size = new System.Drawing.Size(163, 23);
            this.selectCamera.TabIndex = 4;
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("굴림", 10F);
            this.teamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.teamLabel.Location = new System.Drawing.Point(8, 452);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(93, 14);
            this.teamLabel.TabIndex = 0;
            this.teamLabel.Text = "(T) Eye Joah";
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "  Settings";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 20;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 45D;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(2, 372);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(197, 60);
            this.bunifuFlatButton4.TabIndex = 3;
            this.bunifuFlatButton4.Text = "  Settings";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Verdana", 9F);
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "  Work";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 20;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 45D;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(2, 313);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(197, 60);
            this.bunifuFlatButton3.TabIndex = 2;
            this.bunifuFlatButton3.Text = "  Work";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Verdana", 9F);
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "  Blinking";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 20;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 45D;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(2, 251);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(197, 60);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "  Blinking";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Verdana", 9F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 2;
            this.bunifuFlatButton1.ButtonText = "  Home";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 20;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(2, 191);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(197, 60);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "  Home";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Verdana", 9F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tempProfile);
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempProfile
            // 
            this.tempProfile.Image = ((System.Drawing.Image)(resources.GetObject("tempProfile.Image")));
            this.tempProfile.Location = new System.Drawing.Point(18, 2);
            this.tempProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tempProfile.Name = "tempProfile";
            this.tempProfile.Size = new System.Drawing.Size(54, 50);
            this.tempProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tempProfile.TabIndex = 0;
            this.tempProfile.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.Gray;
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Location = new System.Drawing.Point(199, 404);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(533, 74);
            this.panelContainer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(482, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 49;
            this.label2.Text = "label4";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.header.Controls.Add(this.tempLogo);
            this.header.Controls.Add(this.titleLabel);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(199, 71);
            this.header.TabIndex = 1;
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tempLogo
            // 
            this.tempLogo.Image = ((System.Drawing.Image)(resources.GetObject("tempLogo.Image")));
            this.tempLogo.Location = new System.Drawing.Point(22, 23);
            this.tempLogo.Margin = new System.Windows.Forms.Padding(2);
            this.tempLogo.Name = "tempLogo";
            this.tempLogo.Size = new System.Drawing.Size(28, 27);
            this.tempLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tempLogo.TabIndex = 2;
            this.tempLogo.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Verdana", 15F);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(56, 23);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(121, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Blink Blink";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.menuLabel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(199, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(532, 71);
            this.topPanel.TabIndex = 3;
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(459, 8);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 23);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(500, 8);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Verdana", 15F);
            this.menuLabel.Location = new System.Drawing.Point(35, 23);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(70, 25);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Home";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rightEyeImageBox
            // 
            this.rightEyeImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightEyeImageBox.Location = new System.Drawing.Point(559, 319);
            this.rightEyeImageBox.Name = "rightEyeImageBox";
            this.rightEyeImageBox.Size = new System.Drawing.Size(92, 64);
            this.rightEyeImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightEyeImageBox.TabIndex = 45;
            this.rightEyeImageBox.TabStop = false;
            // 
            // thresholdValueText
            // 
            this.thresholdValueText.AutoSize = true;
            this.thresholdValueText.BackColor = System.Drawing.Color.Black;
            this.thresholdValueText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thresholdValueText.Location = new System.Drawing.Point(478, 105);
            this.thresholdValueText.Name = "thresholdValueText";
            this.thresholdValueText.Size = new System.Drawing.Size(38, 12);
            this.thresholdValueText.TabIndex = 48;
            this.thresholdValueText.Text = "label4";
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
            // imageBoxCapturedFrame
            // 
            this.imageBoxCapturedFrame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxCapturedFrame.Location = new System.Drawing.Point(298, 138);
            this.imageBoxCapturedFrame.Margin = new System.Windows.Forms.Padding(2);
            this.imageBoxCapturedFrame.Name = "imageBoxCapturedFrame";
            this.imageBoxCapturedFrame.Size = new System.Drawing.Size(353, 245);
            this.imageBoxCapturedFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxCapturedFrame.TabIndex = 43;
            this.imageBoxCapturedFrame.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 478);
            this.Controls.Add(this.rightEyeImageBox);
            this.Controls.Add(this.thresholdValueText);
            this.Controls.Add(this.eyeBlinkText);
            this.Controls.Add(this.leftEyeImageBox);
            this.Controls.Add(this.eyeBlinkNumText);
            this.Controls.Add(this.imageBoxCapturedFrame);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "                                     Blink Blink";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempProfile)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tempProfile;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.PictureBox tempLogo;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox selectCamera;
        private Emgu.CV.UI.ImageBox rightEyeImageBox;
        private System.Windows.Forms.Label thresholdValueText;
        private System.Windows.Forms.Label eyeBlinkText;
        private Emgu.CV.UI.ImageBox leftEyeImageBox;
        private System.Windows.Forms.Label eyeBlinkNumText;
        private Emgu.CV.UI.ImageBox imageBoxCapturedFrame;
        private System.Windows.Forms.Label label2;
    }
}

