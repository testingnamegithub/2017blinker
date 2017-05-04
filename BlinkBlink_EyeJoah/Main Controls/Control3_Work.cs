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
        public DateTime showDate; //현재 화면에 보여주고 있는 DateTime

        public Control3_Work()
        {
            InitializeComponent();
            makeChart();

            //update realtime text from datetimelabelsettings class
            updateRealtimeText(DateTime.Now);
            showDate = DateTime.Now;
            updateUsageChart(showDate);
        }

        //update realtime text from datetimelabelsettings class
        private void updateRealtimeText(DateTime date)
        {
            CalendarDate calendar = CalendarDate.getInstance();

            realtimeTxt.Text = calendar.Month(date) + " " + calendar.Day(date) + ", " + calendar.Year(date) + " (" + calendar.DayOfWeek(date) + ")";
            showDate = date;
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
            updateUsageChart(showDate);

            //선택된 날짜 확인
            //MessageBox.Show("Date Selected :"+ monthCalendar1.SelectionRange.Start.Month+" "
            //    + monthCalendar1.SelectionRange.Start.Day+" "+ monthCalendar1.SelectionRange.Start.Year);
            //updateRealtimeText(monthCalendar1.SelectionRange.Start.Date);

            updateRealtimeText(monthCalendar1.SelectionRange.Start.Date);
        }

        private void nextDayBtn_Click(object sender, EventArgs e)
        {
            showDate = showDate.AddDays(1);
            updateRealtimeText(showDate);
            updateUsageChart(showDate);
        }

        private void beforeDayBtn_Click(object sender, EventArgs e)
        {
            showDate = showDate.AddDays(-1);
            updateRealtimeText(showDate);
            updateUsageChart(showDate);
        }

        private void updateUsageChart(DateTime date)
        {
            if (date.Day == 30)
            {
                Gauge360Example.gauge360example.updateBreakValue(0);
                Gauge360Example.gauge360example.updateUsageValue(0);
            }
            else if (date.Day == 29)
            {
                Gauge360Example.gauge360example.updateBreakValue(0);
                Gauge360Example.gauge360example.updateUsageValue(0);
            }
            else if (date.Day == 28)
            {
                Gauge360Example.gauge360example.updateBreakValue(86);
                Gauge360Example.gauge360example.updateUsageValue(18);
            }
            else if (date.Day == 27)
            {
                Gauge360Example.gauge360example.updateBreakValue(50);
                Gauge360Example.gauge360example.updateUsageValue(17);
            }
            else if (date.Day == 26)
            {
                Gauge360Example.gauge360example.updateBreakValue(48);
                Gauge360Example.gauge360example.updateUsageValue(8);
            }
            else if (date.Day == 25)
            {
                Gauge360Example.gauge360example.updateBreakValue(95);
                Gauge360Example.gauge360example.updateUsageValue(10);
            }
            else if (date.Day == 24)
            {
                Gauge360Example.gauge360example.updateBreakValue(115);
                Gauge360Example.gauge360example.updateUsageValue(20);
            }
            else if (date.Day == 23)
            {
                Gauge360Example.gauge360example.updateBreakValue(108);
                Gauge360Example.gauge360example.updateUsageValue(18);
            }
            else if (date.Day == 22)
            {
                Gauge360Example.gauge360example.updateBreakValue(88);
                Gauge360Example.gauge360example.updateUsageValue(7);
            }
            else if (date.Day == 21)
            {
                Gauge360Example.gauge360example.updateBreakValue(20);
                Gauge360Example.gauge360example.updateUsageValue(15);
            }
        }

    }
}
