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
            this.recomUsage = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge6 = new LiveCharts.WinForms.SolidGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.actualUsage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usageLabel = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // solidGauge7
            // 
            this.solidGauge7.Location = new System.Drawing.Point(450, 203);
            this.solidGauge7.Margin = new System.Windows.Forms.Padding(4);
            this.solidGauge7.Name = "solidGauge7";
            this.solidGauge7.Size = new System.Drawing.Size(249, 208);
            this.solidGauge7.TabIndex = 12;
            this.solidGauge7.Text = "solidGauge1";
            // 
            // recomUsage
            // 
            this.recomUsage.Location = new System.Drawing.Point(54, 65);
            this.recomUsage.Margin = new System.Windows.Forms.Padding(4);
            this.recomUsage.Name = "recomUsage";
            this.recomUsage.Size = new System.Drawing.Size(249, 208);
            this.recomUsage.TabIndex = 13;
            this.recomUsage.Text = "solidGauge6";
            // 
            // solidGauge6
            // 
            this.solidGauge6.Location = new System.Drawing.Point(450, -8);
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
            this.label1.Location = new System.Drawing.Point(75, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Recommended usage";
            // 
            // actualUsage
            // 
            this.actualUsage.AutoSize = true;
            this.actualUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.actualUsage.Location = new System.Drawing.Point(460, 180);
            this.actualUsage.Name = "actualUsage";
            this.actualUsage.Size = new System.Drawing.Size(138, 26);
            this.actualUsage.TabIndex = 16;
            this.actualUsage.Text = "Actual usage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(498, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Break";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(127, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "120-15";
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usageLabel.Location = new System.Drawing.Point(595, 178);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(90, 29);
            this.usageLabel.TabIndex = 19;
            this.usageLabel.Text = "86 min";
            // 
            // breakLabel
            // 
            this.breakLabel.AutoSize = true;
            this.breakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakLabel.Location = new System.Drawing.Point(573, 387);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(90, 29);
            this.breakLabel.TabIndex = 20;
            this.breakLabel.Text = "18 min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "120 min - 15 break";
            // 
            // Gauge360Example
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.breakLabel);
            this.Controls.Add(this.usageLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.actualUsage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solidGauge6);
            this.Controls.Add(this.recomUsage);
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
        private LiveCharts.WinForms.SolidGauge recomUsage;
        private LiveCharts.WinForms.SolidGauge solidGauge6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label actualUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.Label label6;
    }
}