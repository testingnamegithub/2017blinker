namespace BlinkBlink_EyeJoah.Chart.Uie
{
    partial class UielementsExample
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
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(111, 12);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(21, 12);
            this.Y.TabIndex = 8;
            this.Y.Text = "Y: ";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(37, 12);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(21, 12);
            this.X.TabIndex = 7;
            this.X.Text = "X: ";
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(228, 206);
            this.cartesianChart1.TabIndex = 6;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // UielementsExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 206);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.cartesianChart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UielementsExample";
            this.Text = "UielementsExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}