namespace BlinkBlink_EyeJoah
{
    partial class FaceTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceTraining));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.facebookLoginBtn = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registeredUserBtn = new System.Windows.Forms.Button();
            this.nicknameCheckTxt = new System.Windows.Forms.TextBox();
            this.goNext = new System.Windows.Forms.Button();
            this.takePic = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(170)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 55);
            this.panel1.TabIndex = 16;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.blinkerLogo_gradient4;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(20, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(48, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Blinker";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(675, 15);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(26, 26);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 11;
            this.minimizeBtn.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(710, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 10;
            this.closeButton.TabStop = false;
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Photo Registration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.confirmBtn);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.facebookLoginBtn);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.registeredUserBtn);
            this.panel2.Controls.Add(this.nicknameCheckTxt);
            this.panel2.Controls.Add(this.goNext);
            this.panel2.Controls.Add(this.takePic);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 438);
            this.panel2.TabIndex = 28;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(655, 346);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 16);
            this.checkBox1.TabIndex = 59;
            this.checkBox1.Text = "I Agree.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel11.Location = new System.Drawing.Point(383, 297);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(340, 2);
            this.panel11.TabIndex = 58;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("나눔고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(383, 317);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(340, 23);
            this.textBox3.TabIndex = 57;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Do you agree to use your data information? ";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmBtn.BackgroundImage")));
            this.confirmBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmBtn.Location = new System.Drawing.Point(381, 362);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(342, 51);
            this.confirmBtn.TabIndex = 56;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtnClick);
            this.confirmBtn.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.confirmBtn.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Location = new System.Drawing.Point(381, 251);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(340, 5);
            this.panel10.TabIndex = 55;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8.ForeColor = System.Drawing.Color.Silver;
            this.textBox8.Location = new System.Drawing.Point(381, 216);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(340, 29);
            this.textBox8.TabIndex = 54;
            this.textBox8.Text = "Password Confirm";
            this.textBox8.Click += new System.EventHandler(this.Txtbox_MouseClick);
            this.textBox8.TextChanged += new System.EventHandler(this.PasswordTextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox7.ForeColor = System.Drawing.Color.Silver;
            this.textBox7.Location = new System.Drawing.Point(381, 179);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 29);
            this.textBox7.TabIndex = 53;
            this.textBox7.Text = "Password";
            this.textBox7.Click += new System.EventHandler(this.Txtbox_MouseClick);
            this.textBox7.TextChanged += new System.EventHandler(this.PasswordTextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.ForeColor = System.Drawing.Color.Silver;
            this.textBox5.Location = new System.Drawing.Point(381, 144);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(340, 29);
            this.textBox5.TabIndex = 52;
            this.textBox5.Text = "E-Mail";
            this.textBox5.Click += new System.EventHandler(this.Txtbox_MouseClick);
            this.textBox5.TextChanged += new System.EventHandler(this.TextboxContentsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(422, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Sign up for email";
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.envelope;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Location = new System.Drawing.Point(381, 113);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(33, 25);
            this.panel9.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(381, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 1);
            this.panel5.TabIndex = 47;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(259, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 3);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(581, 100);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 1);
            this.panel7.TabIndex = 48;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(259, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 3);
            this.panel8.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tmon몬소리 Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(540, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "or";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(361, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 375);
            this.panel4.TabIndex = 46;
            // 
            // facebookLoginBtn
            // 
            this.facebookLoginBtn.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.signUpFacebook;
            this.facebookLoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.facebookLoginBtn.Location = new System.Drawing.Point(381, 33);
            this.facebookLoginBtn.Name = "facebookLoginBtn";
            this.facebookLoginBtn.Size = new System.Drawing.Size(342, 51);
            this.facebookLoginBtn.TabIndex = 45;
            this.facebookLoginBtn.Click += new System.EventHandler(this.SignUpFacebookBtnClick);
            this.facebookLoginBtn.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.facebookLoginBtn.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.ForeColor = System.Drawing.Color.Silver;
            this.textBox4.Location = new System.Drawing.Point(558, 262);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 29);
            this.textBox4.TabIndex = 44;
            this.textBox4.Text = "Last Name";
            this.textBox4.Click += new System.EventHandler(this.Txtbox_MouseClick);
            this.textBox4.TextChanged += new System.EventHandler(this.TextboxContentsChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(381, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 29);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "First Name";
            this.textBox1.Click += new System.EventHandler(this.Txtbox_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.TextboxContentsChanged);
            // 
            // registeredUserBtn
            // 
            this.registeredUserBtn.Location = new System.Drawing.Point(0, 0);
            this.registeredUserBtn.Name = "registeredUserBtn";
            this.registeredUserBtn.Size = new System.Drawing.Size(75, 23);
            this.registeredUserBtn.TabIndex = 60;
            // 
            // nicknameCheckTxt
            // 
            this.nicknameCheckTxt.BackColor = System.Drawing.Color.White;
            this.nicknameCheckTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nicknameCheckTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nicknameCheckTxt.ForeColor = System.Drawing.Color.Black;
            this.nicknameCheckTxt.Location = new System.Drawing.Point(431, 373);
            this.nicknameCheckTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nicknameCheckTxt.Name = "nicknameCheckTxt";
            this.nicknameCheckTxt.ReadOnly = true;
            this.nicknameCheckTxt.Size = new System.Drawing.Size(198, 14);
            this.nicknameCheckTxt.TabIndex = 31;
            this.nicknameCheckTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nicknameCheckTxt.TextChanged += new System.EventHandler(this.nicknameCheckTxt_TextChanged);
            // 
            // goNext
            // 
            this.goNext.Location = new System.Drawing.Point(0, 0);
            this.goNext.Name = "goNext";
            this.goNext.Size = new System.Drawing.Size(75, 23);
            this.goNext.TabIndex = 61;
            // 
            // takePic
            // 
            this.takePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.takePic.Location = new System.Drawing.Point(135, 370);
            this.takePic.Margin = new System.Windows.Forms.Padding(2);
            this.takePic.Name = "takePic";
            this.takePic.Size = new System.Drawing.Size(215, 44);
            this.takePic.TabIndex = 28;
            this.takePic.Text = "Take a picture";
            this.takePic.UseVisualStyleBackColor = true;
            this.takePic.Click += new System.EventHandler(this.takePic_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.imageBoxFrameGrabber);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(25, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 249);
            this.panel3.TabIndex = 18;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(0, 0);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(325, 249);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.profile4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(133, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Look at the center of screen";
            // 
            // FaceTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(751, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaceTraining";
            this.Text = "FaceTraining";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button takePic;
        private System.Windows.Forms.Button goNext;
        private System.Windows.Forms.TextBox nicknameCheckTxt;
        private System.Windows.Forms.Button registeredUserBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel facebookLoginBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel confirmBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox3;
    }
}