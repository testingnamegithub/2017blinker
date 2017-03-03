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
using BlinkBlink_EyeJoah.Chart.Section;

namespace BlinkBlink_EyeJoah
{
    public partial class Control2_Blinking : UserControl
    {

        public Control2_Blinking()
        {
            InitializeComponent();
            makeChart1();
            makeChart2();
            //setRealDate();


            //update realtime text from datetimelabelsettings class
            updateRealtimeText();
        }

        //update realtime text from datetimelabelsettings class
        private void updateRealtimeText()
        {
        }


    

        private void makeChart1()
        {
            chartPanel1.Controls.Clear();

            UielementsExample sec = new UielementsExample();
            sec.TopLevel = false;
            sec.AutoScroll = true;
            chartPanel1.Controls.Add(sec);
            sec.Show();
        }

        private void makeChart2() {
            DoughnutExample pie = new DoughnutExample();
            pie.TopLevel = false;
            pie.AutoScroll = true;
            chartPanel2.Controls.Add(pie);
            pie.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == true)
            {
                monthCalendar1.Visible = false;
            }
            else
            {
                monthCalendar1.Visible = true;
            }
        }

        //private void chartPanel1_Paint(object sender, PaintEventArgs e)
        //{
        //    chartPanel1.Controls.Clear();
        //    UielementsExample sec = new UielementsExample();
        //    sec.TopLevel = false;
        //    sec.AutoScroll = true;
        //    chartPanel1.Controls.Add(sec);
        //    sec.Show();

        //    PieChartExample pie = new PieChartExample();
        //    pie.TopLevel = false;
        //    pie.AutoScroll = true;
        //    chartPanel1.Controls.Add(pie);
        //    pie.Show();
        //}
        //private void chartPanel2_Paint(object sender, PaintEventArgs e)
        //{

        //}


    }
}
