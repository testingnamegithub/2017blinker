using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlinkBlink_EyeJoah.Chart.PieChart;
using BlinkBlink_EyeJoah.Chart.Uie;

namespace BlinkBlink_EyeJoah
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Controls.Clear();
            PieChartExample pie = new PieChartExample();
            pie.TopLevel = false;
            pie.AutoScroll = true;
            panel2.Controls.Add(pie);
            pie.Show();

            panel1.Controls.Clear();
            UielementsExample sec = new UielementsExample();
            sec.TopLevel = false;
            sec.AutoScroll = true;
            panel1.Controls.Add(sec);
            sec.Show();
        }
    }
}
