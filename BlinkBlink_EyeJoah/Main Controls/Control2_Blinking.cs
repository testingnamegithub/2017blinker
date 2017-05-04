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
        ////access controls from another classes
        //public static Control2_Blinking control2_blinking;

        public DateTime showDate; //현재 화면에 보여주고 있는 DateTime

        public Control2_Blinking()
        {
            InitializeComponent();
            makeChart1();
            makeChart2();
            //setRealDate();

            //update realtime text from datetimelabelsettings class
            updateRealtimeText(DateTime.Now);
            showDate = DateTime.Now;

            //control2_blinking = this;
            updateBlinkChartByDate(showDate);
        }

        //update realtime text from datetimelabelsettings class
        private void updateRealtimeText(DateTime date)
        {
            CalendarDate calendar = CalendarDate.getInstance();

            realtimeTxt.Text = calendar.Month(date) + " " + calendar.Day(date) + ", " + calendar.Year(date) + " (" + calendar.DayOfWeek(date) + ")";
            showDate = date;
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

        private void makeChart2()
        {
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DoughnutExample.doughnut.updateBlinkPie(4, 4, 1);
            UielementsExample.uiElement.updateBlinkBarValue(8, 8, 9, 10, 11);
            //선택된 날짜 확인
            //MessageBox.Show("Date Selected :"+ monthCalendar1.SelectionRange.Start.Month+" "
            //    + monthCalendar1.SelectionRange.Start.Day+" "+ monthCalendar1.SelectionRange.Start.Year);

            updateRealtimeText(monthCalendar1.SelectionRange.Start);
            updateBlinkChartByDate(showDate);
        }

        private void nextDayBtn_Click(object sender, EventArgs e)
        {
            showDate = showDate.AddDays(1);
            updateRealtimeText(showDate);
            updateBlinkChartByDate(showDate);
        }

        private void beforeDayBtn_Click(object sender, EventArgs e)
        {
            showDate = showDate.AddDays(-1);
            updateRealtimeText(showDate);
            updateBlinkChartByDate(showDate);
        }

        private void updateBlinkChartByDate(DateTime date)
        {
            if (date.Day == 30)
            {
                DoughnutExample.doughnut.updateBlinkPie(0, 0, 0);
                UielementsExample.uiElement.updateBlinkBarValue(0, 0, 0, 0, 0);
            }
            else if (date.Day == 29)
            {
                DoughnutExample.doughnut.updateBlinkPie(0, 0, 0);
                UielementsExample.uiElement.updateBlinkBarValue(0, 0, 0, 0, 0);
            }
            else if (date.Day == 28)
            {
                DoughnutExample.doughnut.updateBlinkPie(2, 1, 2);
                UielementsExample.uiElement.updateBlinkBarValue(5, 6, 9, 8, 10);
            }
            else if (date.Day == 27)
            {
                DoughnutExample.doughnut.updateBlinkPie(3, 3, 1);
                UielementsExample.uiElement.updateBlinkBarValue(7, 8, 9, 8, 10);
            }
            else if (date.Day == 26)
            {
                DoughnutExample.doughnut.updateBlinkPie(2, 2, 1);
                UielementsExample.uiElement.updateBlinkBarValue(5, 8, 9, 7, 11);
            }
            else if (date.Day == 25)
            {
                DoughnutExample.doughnut.updateBlinkPie(3, 4, 4);
                UielementsExample.uiElement.updateBlinkBarValue(7, 8, 7, 10, 7);
            }
            else if (date.Day == 24)
            {
                DoughnutExample.doughnut.updateBlinkPie(4, 3, 1);
                UielementsExample.uiElement.updateBlinkBarValue(9, 11, 9, 10, 8);
            }
            else if (date.Day == 23)
            {
                DoughnutExample.doughnut.updateBlinkPie(2, 4, 1);
                UielementsExample.uiElement.updateBlinkBarValue(8, 8, 9, 8, 6);
            }
            else if (date.Day == 22)
            {
                DoughnutExample.doughnut.updateBlinkPie(1, 4, 1);
                UielementsExample.uiElement.updateBlinkBarValue(6, 8, 9, 6, 10);
            }
            else if (date.Day == 21)
            {
                DoughnutExample.doughnut.updateBlinkPie(3, 4, 1);
                UielementsExample.uiElement.updateBlinkBarValue(8, 8, 6, 10, 11);
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
