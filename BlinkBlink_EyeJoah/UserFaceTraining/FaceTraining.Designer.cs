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
            this.label5 = new System.Windows.Forms.Label();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.registeredUserBtn = new System.Windows.Forms.Button();
            this.nicknameCheckTxt = new System.Windows.Forms.TextBox();
            this.idCheck = new System.Windows.Forms.Button();
            this.goNext = new System.Windows.Forms.Button();
            this.takePic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(630, 40);
            this.panel1.TabIndex = 16;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.blinkerLogo_gradient4;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(24, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(52, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Blinker";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(556, 9);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 20);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBtn.TabIndex = 11;
            this.minimizeBtn.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(591, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 20);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 10;
            this.closeButton.TabStop = false;
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(33, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Take a picture of yourself for blinking accuracy.";
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTxtbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.nameTxtbox.Location = new System.Drawing.Point(346, 220);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(141, 24);
            this.nameTxtbox.TabIndex = 20;
            this.nameTxtbox.Text = "insert nickname";
            this.nameTxtbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameTxtbox_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Photo Registration";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.imageBoxFrameGrabber);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(25, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 230);
            this.panel3.TabIndex = 18;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(22, 10);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(237, 213);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 2;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.registeredUserBtn);
            this.panel2.Controls.Add(this.nicknameCheckTxt);
            this.panel2.Controls.Add(this.idCheck);
            this.panel2.Controls.Add(this.goNext);
            this.panel2.Controls.Add(this.takePic);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.nameTxtbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(2, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 345);
            this.panel2.TabIndex = 28;
            // 
            // registeredUserBtn
            // 
            this.registeredUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(149)))), ((int)(((byte)(135)))));
            this.registeredUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registeredUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredUserBtn.ForeColor = System.Drawing.Color.White;
            this.registeredUserBtn.Location = new System.Drawing.Point(466, 20);
            this.registeredUserBtn.Margin = new System.Windows.Forms.Padding(0);
            this.registeredUserBtn.Name = "registeredUserBtn";
            this.registeredUserBtn.Size = new System.Drawing.Size(134, 32);
            this.registeredUserBtn.TabIndex = 32;
            this.registeredUserBtn.Text = "I\'m a registered user";
            this.registeredUserBtn.UseVisualStyleBackColor = false;
            this.registeredUserBtn.Click += new System.EventHandler(this.registeredUserBtn_Click);
            // 
            // nicknameCheckTxt
            // 
            this.nicknameCheckTxt.BackColor = System.Drawing.Color.White;
            this.nicknameCheckTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nicknameCheckTxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nicknameCheckTxt.ForeColor = System.Drawing.Color.Black;
            this.nicknameCheckTxt.Location = new System.Drawing.Point(360, 257);
            this.nicknameCheckTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nicknameCheckTxt.Name = "nicknameCheckTxt";
            this.nicknameCheckTxt.ReadOnly = true;
            this.nicknameCheckTxt.Size = new System.Drawing.Size(198, 14);
            this.nicknameCheckTxt.TabIndex = 31;
            this.nicknameCheckTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nicknameCheckTxt.TextChanged += new System.EventHandler(this.nicknameCheckTxt_TextChanged);
            // 
            // idCheck
            // 
            this.idCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(149)))), ((int)(((byte)(135)))));
            this.idCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCheck.ForeColor = System.Drawing.Color.White;
            this.idCheck.Location = new System.Drawing.Point(493, 210);
            this.idCheck.Margin = new System.Windows.Forms.Padding(0);
            this.idCheck.Name = "idCheck";
            this.idCheck.Size = new System.Drawing.Size(83, 41);
            this.idCheck.TabIndex = 30;
            this.idCheck.Text = "CHECK";
            this.idCheck.UseVisualStyleBackColor = false;
            this.idCheck.Click += new System.EventHandler(this.idCheck_Click);
            // 
            // goNext
            // 
            this.goNext.Font = new System.Drawing.Font("굴림", 9F);
            this.goNext.Location = new System.Drawing.Point(466, 280);
            this.goNext.Margin = new System.Windows.Forms.Padding(2);
            this.goNext.Name = "goNext";
            this.goNext.Size = new System.Drawing.Size(112, 33);
            this.goNext.TabIndex = 29;
            this.goNext.Text = "Sign Up";
            this.goNext.UseVisualStyleBackColor = true;
            this.goNext.Click += new System.EventHandler(this.goNext_Click);
            // 
            // takePic
            // 
            this.takePic.Font = new System.Drawing.Font("굴림", 9F);
            this.takePic.Location = new System.Drawing.Point(346, 280);
            this.takePic.Margin = new System.Windows.Forms.Padding(2);
            this.takePic.Name = "takePic";
            this.takePic.Size = new System.Drawing.Size(113, 33);
            this.takePic.TabIndex = 28;
            this.takePic.Text = "Take a picture";
            this.takePic.UseVisualStyleBackColor = true;
            this.takePic.Click += new System.EventHandler(this.takePic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.profile4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(395, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 120);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FaceTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(628, 383);
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
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button takePic;
        private System.Windows.Forms.Button goNext;
        private System.Windows.Forms.Button idCheck;
        private System.Windows.Forms.TextBox nicknameCheckTxt;
        private System.Windows.Forms.Button registeredUserBtn;
    }
}