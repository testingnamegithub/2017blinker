namespace BlinkBlink_EyeJoah
{
    partial class Control2_Blinking
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartPanel1 = new System.Windows.Forms.Panel();
            this.chartPanel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.realtimeTxt = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.beforeDayBtn = new System.Windows.Forms.PictureBox();
            this.nextDayBtn = new System.Windows.Forms.PictureBox();
            this.chartPanel1.SuspendLayout();
            this.chartPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextDayBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPanel1
            // 
            this.chartPanel1.Controls.Add(this.monthCalendar1);
            this.chartPanel1.Location = new System.Drawing.Point(24, 107);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Size = new System.Drawing.Size(270, 223);
            this.chartPanel1.TabIndex = 4;
            // 
            // chartPanel2
            // 
            this.chartPanel2.Controls.Add(this.panel1);
            this.chartPanel2.Location = new System.Drawing.Point(320, 107);
            this.chartPanel2.Name = "chartPanel2";
            this.chartPanel2.Size = new System.Drawing.Size(280, 223);
            this.chartPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Blinking frequency in using PC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(52, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Average blinking times per hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(390, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "How well you blink";
            // 
            // realtimeTxt
            // 
            this.realtimeTxt.BackColor = System.Drawing.Color.White;
            this.realtimeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.realtimeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.realtimeTxt.Location = new System.Drawing.Point(145, 50);
            this.realtimeTxt.Name = "realtimeTxt";
            this.realtimeTxt.ReadOnly = true;
            this.realtimeTxt.Size = new System.Drawing.Size(340, 17);
            this.realtimeTxt.TabIndex = 32;
            this.realtimeTxt.Text = "March 1, 2017 (Wednesday)";
            this.realtimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(32, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 36;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BlinkBlink_EyeJoah.Properties.Resources.eye_open;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(109, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 67);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BlinkBlink_EyeJoah.Properties.Resources.calendar_dots;
            this.pictureBox3.Location = new System.Drawing.Point(500, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // beforeDayBtn
            // 
            this.beforeDayBtn.Image = global::BlinkBlink_EyeJoah.Properties.Resources.leftArrow;
            this.beforeDayBtn.Location = new System.Drawing.Point(120, 50);
            this.beforeDayBtn.Name = "beforeDayBtn";
            this.beforeDayBtn.Size = new System.Drawing.Size(30, 20);
            this.beforeDayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beforeDayBtn.TabIndex = 34;
            this.beforeDayBtn.TabStop = false;
            this.beforeDayBtn.Click += new System.EventHandler(this.beforeDayBtn_Click);
            // 
            // nextDayBtn
            // 
            this.nextDayBtn.Image = global::BlinkBlink_EyeJoah.Properties.Resources.rightArrow;
            this.nextDayBtn.Location = new System.Drawing.Point(460, 50);
            this.nextDayBtn.Name = "nextDayBtn";
            this.nextDayBtn.Size = new System.Drawing.Size(30, 20);
            this.nextDayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nextDayBtn.TabIndex = 33;
            this.nextDayBtn.TabStop = false;
            this.nextDayBtn.Click += new System.EventHandler(this.nextDayBtn_Click);
            // 
            // Control2_Blinking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.beforeDayBtn);
            this.Controls.Add(this.nextDayBtn);
            this.Controls.Add(this.realtimeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartPanel2);
            this.Controls.Add(this.chartPanel1);
            this.Name = "Control2_Blinking";
            this.Size = new System.Drawing.Size(670, 386);
            this.chartPanel1.ResumeLayout(false);
            this.chartPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextDayBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel chartPanel1;
        private System.Windows.Forms.Panel chartPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox realtimeTxt;
        private System.Windows.Forms.PictureBox nextDayBtn;
        private System.Windows.Forms.PictureBox beforeDayBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel1;
    }
}
