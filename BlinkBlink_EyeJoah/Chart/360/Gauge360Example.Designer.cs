namespace BlinkBlink_EyeJoah.Chart._360
{
    partial class Gauge360Example
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
            this.solidGauge7 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge5 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge6 = new LiveCharts.WinForms.SolidGauge();
            this.SuspendLayout();
            // 
            // solidGauge7
            // 
            this.solidGauge7.Location = new System.Drawing.Point(401, 12);
            this.solidGauge7.Name = "solidGauge7";
            this.solidGauge7.Size = new System.Drawing.Size(174, 139);
            this.solidGauge7.TabIndex = 12;
            this.solidGauge7.Text = "solidGauge1";
            // 
            // solidGauge5
            // 
            this.solidGauge5.Location = new System.Drawing.Point(12, 12);
            this.solidGauge5.Name = "solidGauge5";
            this.solidGauge5.Size = new System.Drawing.Size(174, 139);
            this.solidGauge5.TabIndex = 13;
            this.solidGauge5.Text = "solidGauge6";
            // 
            // solidGauge6
            // 
            this.solidGauge6.Location = new System.Drawing.Point(210, 12);
            this.solidGauge6.Name = "solidGauge6";
            this.solidGauge6.Size = new System.Drawing.Size(174, 139);
            this.solidGauge6.TabIndex = 14;
            this.solidGauge6.Text = "solidGauge2";
            // 
            // Gauge360Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 228);
            this.Controls.Add(this.solidGauge6);
            this.Controls.Add(this.solidGauge5);
            this.Controls.Add(this.solidGauge7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gauge360Example";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gauge360Example";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.SolidGauge solidGauge7;
        private LiveCharts.WinForms.SolidGauge solidGauge5;
        private LiveCharts.WinForms.SolidGauge solidGauge6;
    }
}