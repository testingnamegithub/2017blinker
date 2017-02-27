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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solidGauge7
            // 
            this.solidGauge7.Location = new System.Drawing.Point(573, 18);
            this.solidGauge7.Margin = new System.Windows.Forms.Padding(4);
            this.solidGauge7.Name = "solidGauge7";
            this.solidGauge7.Size = new System.Drawing.Size(249, 208);
            this.solidGauge7.TabIndex = 12;
            this.solidGauge7.Text = "solidGauge1";
            // 
            // solidGauge5
            // 
            this.solidGauge5.Location = new System.Drawing.Point(17, 18);
            this.solidGauge5.Margin = new System.Windows.Forms.Padding(4);
            this.solidGauge5.Name = "solidGauge5";
            this.solidGauge5.Size = new System.Drawing.Size(249, 208);
            this.solidGauge5.TabIndex = 13;
            this.solidGauge5.Text = "solidGauge6";
            // 
            // solidGauge6
            // 
            this.solidGauge6.Location = new System.Drawing.Point(300, 18);
            this.solidGauge6.Margin = new System.Windows.Forms.Padding(4);
            this.solidGauge6.Name = "solidGauge6";
            this.solidGauge6.Size = new System.Drawing.Size(249, 208);
            this.solidGauge6.TabIndex = 14;
            this.solidGauge6.Text = "solidGauge2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(26, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Recommended usage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(359, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Actual usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(664, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Break";
            // 
            // Gauge360Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solidGauge6);
            this.Controls.Add(this.solidGauge5);
            this.Controls.Add(this.solidGauge7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Gauge360Example";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gauge360Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.SolidGauge solidGauge7;
        private LiveCharts.WinForms.SolidGauge solidGauge5;
        private LiveCharts.WinForms.SolidGauge solidGauge6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}