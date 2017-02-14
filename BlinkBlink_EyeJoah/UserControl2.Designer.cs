namespace BlinkBlink_EyeJoah
{
    partial class UserControl2
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
            this.SuspendLayout();
            // 
            // chartPanel1
            // 
            this.chartPanel1.Location = new System.Drawing.Point(56, 509);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Size = new System.Drawing.Size(616, 367);
            this.chartPanel1.TabIndex = 4;
            this.chartPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.chartPanel1_Paint);
            // 
            // chartPanel2
            // 
            this.chartPanel2.Location = new System.Drawing.Point(56, 54);
            this.chartPanel2.Name = "chartPanel2";
            this.chartPanel2.Size = new System.Drawing.Size(616, 414);
            this.chartPanel2.TabIndex = 5;
            this.chartPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.chartPanel2_Paint);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chartPanel2);
            this.Controls.Add(this.chartPanel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(725, 910);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel chartPanel2;
        private System.Windows.Forms.Panel chartPanel1;
    }
}
