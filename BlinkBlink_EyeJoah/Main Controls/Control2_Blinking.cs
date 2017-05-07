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
        LocalDatabase localDB;
        string tableTypeName;

        public Control2_Blinking()
        {
            InitializeComponent();
            makeChart1();
            makeChart2();
            localDB = LocalDatabase.getInstance();
            //setRealDate();

            //update realtime text from datetimelabelsettings class
            updateRealtimeText(DateTime.Now);
            showDate = DateTime.Now;

            //control2_blinking = this;

            //inserting data sm5duck
            insertingDataToSm5duck();

            //오늘의 chart 
            //updateTodayBlinkChart();

            updateBlinkChartByDate(showDate);
        }

        private void insertingDataToSm5duck()
        {
            if(Form1.mainForm.GetUserName().Equals("sm5duck"))
            {
                localDB.InsertDataToTable("sm5duck", "d20170506", 15, 6);
                localDB.InsertDataToTable("sm5duck", "d20170506", 16, 8);
                localDB.InsertDataToTable("sm5duck", "d20170506", 17, 11);
                localDB.InsertDataToTable("sm5duck", "d20170506", 18, 9);
                localDB.InsertDataToTable("sm5duck", "d20170506", 19, 11);
            }
        }

        ////오늘의 chart
        //private void updateTodayBlinkChart()
        //{
        //    DoughnutExample.doughnut.updateBlinkPie(1,1, 1);
        //    UielementsExample.uiElement.updateBlinkBarValue(7, 8, 10, 11, 6);
        //}

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
            tableTypeName = "d" + date.Year + date.Month.ToString("00") + date.Day.ToString("00");

            int[,] blinkDataArray = new int [5,2];
            int normal=0, bad=0, good = 0;

            if(localDB.TableExists(tableTypeName,Form1.mainForm.GetUserName())) //테이블 있으면
            {
                localDB.ReadAllDataFromTable(ref blinkDataArray, Form1.mainForm.GetUserName(), tableTypeName);
                for(int i=0;i<5;i++)
                {
                    if (blinkDataArray[i, 1] > 8)
                        good++;
                    else if (blinkDataArray[i, 1] == 8)
                        normal++;
                    else
                        bad++;
                }

                DoughnutExample.doughnut.updateBlinkPie(good, normal, bad);
                UielementsExample.uiElement.updateBlinkBarValue(blinkDataArray[0,1], blinkDataArray[1, 1],
                                         blinkDataArray[2, 1], blinkDataArray[3, 1], blinkDataArray[4, 1]);
            }
            else //테이블 없으면
            {
                DoughnutExample.doughnut.updateBlinkPie(0, 0, 0);
                UielementsExample.uiElement.updateBlinkBarValue(0, 0, 0, 0, 0);
            }
            
        }

    }
}
