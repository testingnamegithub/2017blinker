using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BlinkBlink_EyeJoah
{
    public partial class DistanceAlertScreencs : Form
    {
        private Rectangle workingArea;

        public DistanceAlertScreencs()
        {
            InitializeComponent();
            workingArea = Screen.GetWorkingArea(this);

            this.Location = new Point(workingArea.Right,
                                      workingArea.Bottom - Size.Height - 30);
            formShow();
        }

        private void formShow()
        {
            Point location = new Point(0, 0);
            for (int i = 0; i < 412; i++)
            {
                location = new Point(workingArea.Right - i, workingArea.Bottom - Size.Height - 30);
                this.Location = location;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
