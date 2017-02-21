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
            this.panel8 = new System.Windows.Forms.Panel();
            this.picturebox_BlinkStaticis = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.picturebox_Home = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.picturebox_Setting = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.picturebox_Work = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tempProfile = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.tempLogo = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.menuLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.thresholdValueText = new System.Windows.Forms.Label();
            this.eyeBlinkText = new System.Windows.Forms.Label();
            this.eyeBlinkNumText = new System.Windows.Forms.Label();
            this.rightEyeImageBox = new Emgu.CV.UI.ImageBox();
            this.leftEyeImageBox = new Emgu.CV.UI.ImageBox();
            this.imageBoxCapturedFrame = new Emgu.CV.UI.ImageBox();
            this.sidebar.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_BlinkStaticis)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Home)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Setting)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Work)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempProfile)).BeginInit();
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
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.teamLabel);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(199, 386);
            this.sidebar.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(148)))), ((int)(((byte)(130)))));
            this.panel8.Controls.Add(this.picturebox_BlinkStaticis);
            this.panel8.Location = new System.Drawing.Point(0, 191);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(44, 44);
            this.panel8.TabIndex = 50;
            // 
            // picturebox_BlinkStaticis
            // 
            this.picturebox_BlinkStaticis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_BlinkStaticis.Location = new System.Drawing.Point(2, 2);
            this.picturebox_BlinkStaticis.Name = "picturebox_BlinkStaticis";
            this.picturebox_BlinkStaticis.Size = new System.Drawing.Size(40, 40);
            this.picturebox_BlinkStaticis.TabIndex = 0;
            this.picturebox_BlinkStaticis.TabStop = false;
            this.picturebox_BlinkStaticis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_Click);
            this.picturebox_BlinkStaticis.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.picturebox_BlinkStaticis.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(148)))), ((int)(((byte)(130)))));
            this.panel7.Controls.Add(this.picturebox_Home);
            this.panel7.Location = new System.Drawing.Point(0, 144);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(44, 44);
            this.panel7.TabIndex = 49;
            // 
            // picturebox_Home
            // 
            this.picturebox_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_Home.Location = new System.Drawing.Point(2, 2);
            this.picturebox_Home.Name = "picturebox_Home";
            this.picturebox_Home.Size = new System.Drawing.Size(40, 40);
            this.picturebox_Home.TabIndex = 0;
            this.picturebox_Home.TabStop = false;
            this.picturebox_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_Click);
            this.picturebox_Home.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.picturebox_Home.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Location = new System.Drawing.Point(0, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(199, 44);
            this.panel5.TabIndex = 52;
            this.panel5.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.panel5.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(53, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Settings";
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton4_Click);
            this.label5.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.label5.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(148)))), ((int)(((byte)(130)))));
            this.panel10.Controls.Add(this.picturebox_Setting);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(44, 44);
            this.panel10.TabIndex = 52;
            // 
            // picturebox_Setting
            // 
            this.picturebox_Setting.Location = new System.Drawing.Point(2, 2);
            this.picturebox_Setting.Name = "picturebox_Setting";
            this.picturebox_Setting.Size = new System.Drawing.Size(40, 40);
            this.picturebox_Setting.TabIndex = 49;
            this.picturebox_Setting.TabStop = false;
            this.picturebox_Setting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton4_Click);
            this.picturebox_Setting.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.picturebox_Setting.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Location = new System.Drawing.Point(0, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 44);
            this.panel4.TabIndex = 51;
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton3_Click);
            this.panel4.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.panel4.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(58, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Work";
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton3_Click);
            this.label4.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(148)))), ((int)(((byte)(130)))));
            this.panel9.Controls.Add(this.picturebox_Work);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(44, 44);
            this.panel9.TabIndex = 51;
            // 
            // picturebox_Work
            // 
            this.picturebox_Work.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picturebox_Work.Location = new System.Drawing.Point(2, 2);
            this.picturebox_Work.Name = "picturebox_Work";
            this.picturebox_Work.Size = new System.Drawing.Size(40, 40);
            this.picturebox_Work.TabIndex = 0;
            this.picturebox_Work.TabStop = false;
            this.picturebox_Work.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton3_Click);
            this.picturebox_Work.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.picturebox_Work.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(199, 44);
            this.panel3.TabIndex = 50;
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_Click);
            this.panel3.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.panel3.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(58, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blinking";
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton2_Click);
            this.label3.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.label3.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 44);
            this.panel2.TabIndex = 49;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_Click);
            this.panel2.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.panel2.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 도현", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(58, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuFlatButton1_Click);
            this.label2.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.MouseHover);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(168)))), ((int)(((byte)(150)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tempProfile);
            this.panel1.Location = new System.Drawing.Point(1, 68);
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
            this.label1.Location = new System.Drawing.Point(83, 19);
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
            this.tempProfile.Location = new System.Drawing.Point(10, 2);
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
            this.panelContainer.Location = new System.Drawing.Point(199, 68);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(533, 325);
            this.panelContainer.TabIndex = 2;
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
            this.titleLabel.Location = new System.Drawing.Point(51, 23);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(121, 25);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Blink Blink";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.topPanel.Controls.Add(this.label6);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
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
            this.rightEyeImageBox.Location = new System.Drawing.Point(559, 319);
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
            this.ClientSize = new System.Drawing.Size(731, 386);
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
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_BlinkStaticis)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Home)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Setting)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_Work)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempProfile)).EndInit();
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
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tempProfile;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.PictureBox tempLogo;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox rightEyeImageBox;
        private System.Windows.Forms.Label thresholdValueText;
        private System.Windows.Forms.Label eyeBlinkText;
        private Emgu.CV.UI.ImageBox leftEyeImageBox;
        private System.Windows.Forms.Label eyeBlinkNumText;
        private Emgu.CV.UI.ImageBox imageBoxCapturedFrame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picturebox_Home;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picturebox_Work;
        private System.Windows.Forms.PictureBox picturebox_BlinkStaticis;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox picturebox_Setting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

