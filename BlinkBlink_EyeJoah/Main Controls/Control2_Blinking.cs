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
        public DateTime showDate; //현재 화면에 보여주고 있는 DateTime
        LocalDatabase localDB;
        string tableTypeName;

        public Control2_Blinking()
        {
            InitializeComponent();
            makeChart1();
            makeChart2();
            localDB = LocalDatabase.getInstance();

            //update realtime text from datetimelabelsettings class
            updateRealtimeText(DateTime.Now);
            showDate = DateTime.Now;

            //inserting data sm5duck
            insertingDataToSm5duck();

            updateBlinkChartByDate(showDate);
        }

        private void insertingDataToSm5duck()
        {
            if(Form1.mainForm.GetUserName().Equals("sm5duck"))
            {
                localDB.InsertDataBlinkTable("sm5duck", "blink20170506", 15, 6);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170506", 16, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170506", 17, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170506", 18, 9);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170506", 19, 11);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170509", 16, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170509", 17, 12);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170509", 18, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170509", 19, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170509", 20, 9);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170510", 18, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170510", 19, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170510", 20, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170510", 21, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170510", 22, 9);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170511", 16, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170511", 17, 9);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170511", 18, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170511", 19, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170511", 20, 7);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170512", 19, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170512", 20, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170512", 21, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170512", 22, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170512", 23, 7);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170513", 10, 9);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170513", 11, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170513", 12, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170513", 13, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170513", 14, 9);
                //new
                localDB.InsertDataBlinkTable("sm5duck", "blink20170531", 15, 6);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170531", 16, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170531", 17, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170531", 18, 9);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170531", 19, 11);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170530", 16, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170530", 17, 12);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170530", 18, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170530", 19, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170530", 20, 9);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170529", 18, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170529", 19, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170529", 20, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170529", 21, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170529", 22, 9);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170528", 16, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170528", 17, 9);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170528", 18, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170528", 19, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170528", 20, 7);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170527", 19, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170527", 20, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170527", 21, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170527", 22, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170527", 23, 7);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170526", 10, 9);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170526", 11, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170526", 12, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170526", 13, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170526", 14, 9);
                //new june
                localDB.InsertDataBlinkTable("sm5duck", "blink20170601", 17, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170601", 18, 12);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170601", 19, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170601", 20, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170601", 21, 9);

                localDB.InsertDataBlinkTable("sm5duck", "blink20170602", 9, 7);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170602", 10, 10);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170602", 11, 8);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170602", 12, 11);
                localDB.InsertDataBlinkTable("sm5duck", "blink20170602", 13, 9);
            }
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
            //선택된 날짜 확인
            //MessageBox.Show("Date Selected :"+ monthCalendar1.SelectionRange.Start.Month+" "
            //    + monthCalendar1.SelectionRange.Start.Day+" "+ monthCalendar1.SelectionRange.Start.Year);
            showDate = monthCalendar1.SelectionRange.Start.Date;
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
            tableTypeName = "blink" + date.Year + date.Month.ToString("00") + date.Day.ToString("00");

            int[,] blinkDataArray = new int [5,2];
            int normal=0, bad=0, good = 0;

            if(localDB.TableExists(tableTypeName,Form1.mainForm.GetUserName())) //테이블 있으면
            {
                localDB.ReadDataBlinkTable(ref blinkDataArray, Form1.mainForm.GetUserName(), tableTypeName);
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
