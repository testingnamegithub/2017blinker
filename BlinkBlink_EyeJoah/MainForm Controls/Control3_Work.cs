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
using BlinkBlink_EyeJoah.Chart._360;

namespace BlinkBlink_EyeJoah
{
    public partial class Control3_Work : UserControl
    {
        public Control3_Work()
        {
            InitializeComponent();
            makeChart();
        }

        private void makeChart()
        {
            chartPanel1.Controls.Clear();
            // FunnelExample fun = new FunnelExample();
            Gauge360Example fun = new Gauge360Example();
            fun.TopLevel = false;
            fun.AutoScroll = true;
            chartPanel1.Controls.Add(fun);
            fun.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }
    }
}
