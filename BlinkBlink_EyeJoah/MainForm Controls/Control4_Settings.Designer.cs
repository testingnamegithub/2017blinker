namespace BlinkBlink_EyeJoah
{
    partial class Control4_Settings
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
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.BackColor = System.Drawing.Color.Silver;
            this.scrollPanel.Location = new System.Drawing.Point(0, 158);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(607, 207);
            this.scrollPanel.TabIndex = 52;
            // 
            // videoBox
            // 
            this.videoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.videoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoBox.InitialImage = null;
            this.videoBox.Location = new System.Drawing.Point(192, 15);
            this.videoBox.Margin = new System.Windows.Forms.Padding(4);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(233, 136);
            this.videoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoBox.TabIndex = 51;
            this.videoBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Control4_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scrollPanel);
            this.Controls.Add(this.videoBox);
            this.Name = "Control4_Settings";
            this.Size = new System.Drawing.Size(631, 540);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.Button button1;
    }
}
