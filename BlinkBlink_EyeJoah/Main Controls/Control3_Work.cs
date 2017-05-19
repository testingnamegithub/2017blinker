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
        LocalDatabase localDB;
        string tableTypeName;

        public Control3_Work()
        {
            InitializeComponent();
            makeChart();
            localDB = LocalDatabase.getInstance();

            //update realtime text from datetimelabelsettings class
            updateRealtimeText(DateTime.Now);
            showDate = DateTime.Now;

            //inserting data sm5duck
            insertingDataToSm5duck();

            UpdateUsageChartByDate(showDate);
        }

        private void insertingDataToSm5duck()
        {
            //6,9,10,11,12,13
            localDB.InsertDataWorkTable("sm5duck", "work20170506", 83, 17);
            localDB.InsertDataWorkTable("sm5duck", "work20170509", 110, 8);
            localDB.InsertDataWorkTable("sm5duck", "work20170510", 107, 22);
            localDB.InsertDataWorkTable("sm5duck", "work20170511", 45, 15);
            localDB.InsertDataWorkTable("sm5duck", "work20170512", 137, 21);
            localDB.InsertDataWorkTable("sm5duck", "work20170513", 23, 15);

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
            showDate = monthCalendar1.SelectionRange.Start.Date;
            UpdateUsageChartByDate(showDate);

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
            UpdateUsageChartByDate(showDate);
        }

        private void beforeDayBtn_Click(object sender, EventArgs e)
        {
            showDate = showDate.AddDays(-1);
            updateRealtimeText(showDate);
            UpdateUsageChartByDate(showDate);
        }

        private void UpdateUsageChartByDate(DateTime date)
        {
            tableTypeName = "work" + date.Year + date.Month.ToString("00") + date.Day.ToString("00");
            int usageTime = 0, breakTime = 0;

            if (localDB.TableExists(tableTypeName, Form1.mainForm.GetUserName())) //테이블 있으면
            {
                localDB.ReadDataWorkTable(ref usageTime, ref breakTime, Form1.mainForm.GetUserName(), tableTypeName);

                Gauge360Example.gauge360example.updateUsageValue(usageTime);
                Gauge360Example.gauge360example.updateBreakValue(breakTime);
            }
            else //테이블 없으면
            {
                Gauge360Example.gauge360example.updateUsageValue(0);
                Gauge360Example.gauge360example.updateBreakValue(0);
            }
        }

    }
}
