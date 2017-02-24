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
            this.chartPanel1.Location = new System.Drawing.Point(56, 29);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Size = new System.Drawing.Size(616, 644);
            this.chartPanel1.TabIndex = 4;
            // 
            // chartPanel2
            // 
            this.chartPanel2.Location = new System.Drawing.Point(56, 705);
            this.chartPanel2.Name = "chartPanel2";
            this.chartPanel2.Size = new System.Drawing.Size(616, 593);
            this.chartPanel2.TabIndex = 0;
            // 
            // UserControl2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.chartPanel2);
            this.Controls.Add(this.chartPanel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(774, 1169);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel chartPanel1;
        private System.Windows.Forms.Panel chartPanel2;
    }
}
