using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using BlinkBlink_EyeJoah.Chart.PieChart;
using BlinkBlink_EyeJoah.Chart.Section;
using BlinkBlink_EyeJoah.Chart.Uie;
using BlinkBlink_EyeJoah.Chart.Funnel_chart;

namespace BlinkBlink_EyeJoah
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            /*panel2.Controls.Clear();
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
             sec.Show();*/
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.Controls.Clear();
            FunnelExample fun = new FunnelExample();
            fun.TopLevel = false;
            fun.AutoScroll = true;
            panel3.Controls.Add(fun);
            fun.Show();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
