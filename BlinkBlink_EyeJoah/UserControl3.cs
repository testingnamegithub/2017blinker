using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlinkBlink_EyeJoah.PieChart;
using BlinkBlink_EyeJoah.Constatnt;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
//using System.nullReferenceException;

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
            panel1.Controls.Clear();
            ConstantChanges con = new ConstantChanges();
            con.TopLevel = false;
            con.AutoScroll = true;
            panel1.Controls.Add(con);
            con.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Controls.Clear();
            PieChartExample pie = new PieChartExample();
            pie.TopLevel = false;
            pie.AutoScroll = true;
            panel2.Controls.Add(pie);
            pie.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
