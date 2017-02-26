using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlinkBlink_EyeJoah
{
    public partial class Settings_Scroll : UserControl
    {
        public Settings_Scroll()
        {
            InitializeComponent();
        }

        //비디오 박스 컨텐츠 삽입
        public void setVideo(Image videoImage)
        {
            Control4_Settings.control4_settings.updateVideo(videoImage);
        }
        //비디오 박스 초기화
        public void emptyVideo()
        {
            Control4_Settings.control4_settings.emptyVideo();
        }

        //콤보박스 데이터 셋
        private void Settings_Scroll_Load(object sender, EventArgs e)
        {
            string[] cbData_MonitorColor = {  "1200k: Ember",
            "1900k: Candle",
            "2300k: Dim Incandescent",
            "2700k: Incandescent",
            "3400k: Halogen",
            "4200k: Fluorescent",
            "5000k: Sunlight" };
            string[] cbData_EyeExercise = { "= Random =","Clockwise","Counterclockwise","Left and right","Diagonally (Right Top)","Diagonally (Right Below)","Infinity"};
            string[] cbData_WorkTime = { "20 min (Recommended)", "30 min","40 min", "50 min", "60 min" };
            string[] cbData_BreakTime = { "5 min","10 min", "15 min",  "20 min (Recommended)", "25 min", "30 min" };

            //콤보박스에 데이터 초기화
            cb_monitorColor.Items.AddRange(cbData_MonitorColor);
            cb_exercises.Items.AddRange(cbData_EyeExercise);
            cb_work.Items.AddRange(cbData_WorkTime);
            cb_break.Items.AddRange(cbData_BreakTime);

            //처음 선택값(default) 지정
            cb_monitorColor.SelectedIndex = 0;
            cb_exercises.SelectedIndex = 0;
            cb_work.SelectedIndex = 0;
            cb_break.SelectedIndex = 3;
        }

        bool isCheckedMonitor = false;
        bool isCheckedImage = false;
        bool isCheckedMsg = false;
        bool isCheckedTimeSet = false;
        bool isCheckedEyeExercise = false;

        //select or customize(only one checked)
        private void check_SelectTime_CheckedChanged(object sender, EventArgs e)
        {
            check_CustomizeTime.Checked = ! check_SelectTime.Checked;
            if (check_SelectTime.Checked == true)
            {
                work1.Enabled = true;
                break1.Enabled = true;
                cb_work.Enabled = true;
                cb_break.Enabled = true;
                work2.Enabled = false;
                break2.Enabled = false;
                min1.Enabled = false;
                min2.Enabled = false;
                txt_work.Enabled = false;
                txt_break.Enabled = false;
            }else
            {
                work1.Enabled = false;
                break1.Enabled = false;
                cb_work.Enabled = false;
                cb_break.Enabled = false;
                work2.Enabled =true;
                break2.Enabled = true;
                min1.Enabled = true;
                min2.Enabled = true;
                txt_work.Enabled = true;
                txt_break.Enabled = true;
            }
        }
        private void check_CustomizeTime_CheckedChanged(object sender, EventArgs e)
        {
            check_SelectTime.Checked = !check_CustomizeTime.Checked;
            if (check_CustomizeTime.Checked == true)
            {
                work1.Enabled = false;
                break1.Enabled = false;
                cb_work.Enabled = false;
                cb_break.Enabled = false;
                work2.Enabled = true;
                break2.Enabled = true;
                min1.Enabled = true;
                min2.Enabled = true;
                txt_work.Enabled = true;
                txt_break.Enabled = true;
            }
            else
            {
                work1.Enabled = true;
                break1.Enabled = true;
                cb_work.Enabled = true;
                cb_break.Enabled = true;
                work2.Enabled = false;
                break2.Enabled = false;
                min1.Enabled = false;
                min2.Enabled = false;
                txt_work.Enabled = false;
                txt_break.Enabled = false;
            }
        }

        //click- check/uncheck
        private void radiobtn_Monitor_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedMonitor = radiobtn_Monitor.Checked;
        }
        private void radiobtn_Monitor_Click(object sender,EventArgs e)
        {
            if(radiobtn_Monitor.Checked && !isCheckedMonitor)
            {
                radiobtn_Monitor.Checked = false;
                cb_monitorColor.Enabled = false;
            }else
            {
                radiobtn_Monitor.Checked = true;
                isCheckedMonitor = false;
                cb_monitorColor.Enabled = true;
            }
        }

        //click- check/uncheck
        private void radiobtn_Image_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedImage = radiobtn_Image.Checked;
        }
        private void radiobtn_Image_Click(object sender, EventArgs e)
        {
            if (radiobtn_Image.Checked && !isCheckedImage)
            {
                radiobtn_Image.Checked = false;
                emptyVideo();
            }
            else
            {
                radiobtn_Image.Checked = true;
                isCheckedImage = false;
                cb_monitorColor.Enabled = false;
                setVideo(Properties.Resources._1);
            }
        }

        //click- check/uncheck
        private void radiobtn_MsgAlert_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedMsg = radiobtn_MsgAlert.Checked;
        }
        private void radiobtn_MsgAlert_Click(object sender, EventArgs e)
        {
            if (radiobtn_MsgAlert.Checked && !isCheckedMsg)
            {
                radiobtn_MsgAlert.Checked = false;
                emptyVideo();
            }
            else
            {
                radiobtn_MsgAlert.Checked = true;
                isCheckedMsg = false;
                setVideo(Properties.Resources._3);
            }
        }

        //click- check/uncheck
        private void radiobtn_TimeSet_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedTimeSet = radiobtn_TimeSet.Checked;
        }
        private void radiobtn_TimeSet_Click(object sender, EventArgs e)
        {
            if (radiobtn_TimeSet.Checked && !isCheckedTimeSet) //체크해제
            {
                radiobtn_TimeSet.Checked = false;
                check_SelectTime.Enabled = false;
                check_CustomizeTime.Enabled = false;
                cb_work.Enabled = false;
                cb_break.Enabled = false;
                work1.Enabled = false;
                break1.Enabled = false;
            }
            else //체크
            {
                radiobtn_TimeSet.Checked = true;
                isCheckedTimeSet = false;
                check_SelectTime.Enabled = true;
                check_CustomizeTime.Enabled = true;
                cb_work.Enabled = true;
                cb_break.Enabled = true;
                work1.Enabled = true;
                break1.Enabled = true;
            }
        }

        //click- check/uncheck
        private void radiobtn_EyeExercise_CheckedChanged(object sender, EventArgs e)
        {
            isCheckedEyeExercise = radiobtn_EyeExercise.Checked;
        }
        private void radiobtn_EyeExercise_Click(object sender, EventArgs e)
        {
            if (radiobtn_EyeExercise.Checked && !isCheckedEyeExercise)
            {
                radiobtn_EyeExercise.Checked = false;
                cb_exercises.Enabled = false;
            }
            else
            {
                radiobtn_EyeExercise.Checked = true;
                isCheckedEyeExercise = false;
                cb_exercises.Enabled = true;
                cb_work.Enabled = false;
                cb_break.Enabled = false;
                work1.Enabled = false;
                break1.Enabled = false;
            }
        }

        private void cb_exercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_exercises.SelectedIndex)
            {
                //case 0: //random
                //    setVideo(Properties.Resources._10);
                //    break;
                case 1: //clockwise
                    setVideo(Properties.Resources._6);
                    break;
                case 2: //counterclockwise
                    setVideo(Properties.Resources._7);
                    break;
                case 3: //left and right
                    setVideo(Properties.Resources._11);
                    break;
                case 4: //right top
                    setVideo(Properties.Resources._8);
                    break;
                case 5: //right below
                    setVideo(Properties.Resources._9);
                    break;
                case 6: //infinity
                    setVideo(Properties.Resources._10);
                    break;
            }
        }

 
    }
}
