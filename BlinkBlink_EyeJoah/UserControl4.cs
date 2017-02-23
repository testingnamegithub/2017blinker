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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("30");
            comboBox1.Items.Add("40");
            comboBox1.Items.Add("50");

            comboBox2.Items.Add("ClockWise");
            comboBox2.Items.Add("CounterClockWise");
            comboBox2.Items.Add("LeftAndRight");
            comboBox2.Items.Add("Diagonal_RightTop");
            comboBox2.Items.Add("Diagonal_RightBelow");
            comboBox2.Items.Add("Infinity");
            comboBox2.Items.Add("Random");

            comboBox1.Visible = false;
            comboBox2.Visible = false;
            label5.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "모니터 거리알람";
            pictureBox2.Image = Properties.Resources._3;
            label3.Text = "모니터와 거리가 가까워질시 알람을 줍니다";
        }

        private void UpdateLabel1(object sender, EventArgs e)
        {
            label1.Text = "반 투명이미지";
            pictureBox2.Image = Properties.Resources._1;
            label3.Text = "사용자의 작업에 방해하지 않게 \n반투명이지를 보여줍니다.";

        }

        private void up2(object sender, EventArgs e)
        {
            label1.Text = "화면 밝기 조절";
            pictureBox2.Image = Properties.Resources._2;
            label3.Text = "사용자의 눈깜빡임을 무의식으로\n교정시키기위해 사용됩니다";
        }

        private void up3(object sender, EventArgs e)
        {
            label1.Text = "20-20-20알람";
            pictureBox2.Image = Properties.Resources._4;
            label3.Text = "사용자에게 20분마다 20peat를 \n쉬는 운동을 알려줍니다";
        }

        private void up4(object sender, EventArgs e)
        {
            label1.Text = "눈 운동 에니메이션";
            pictureBox2.Image = Properties.Resources._5;
            label3.Text = "일정시간 사용자가 작업시 \n눈 건강을 위해 운동을 알려줍니다.";
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            label5.Visible = false;
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selects = comboBox2.SelectedItem.ToString();
            switch (selects)
            {
                case "ClockWise":
                    pictureBox2.Image = Properties.Resources._6;
                    break;
                case "CounterClockWise":
                    pictureBox2.Image = Properties.Resources._7;
                    break;
                case "LeftAndRight":
                    pictureBox2.Image = Properties.Resources._11;
                    break;
                case "Diagonal_RightTop":
                    pictureBox2.Image = Properties.Resources._8;
                    break;
                case "Diagonal_RightBelow":
                    pictureBox2.Image = Properties.Resources._9;
                    break;
                case "Infinity":
                    pictureBox2.Image = Properties.Resources._10;
                    break;
                case "Random":
                    pictureBox2.Image = Properties.Resources._10;
                    break;

                default:
                    MessageBox.Show("선택해주세요");
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
