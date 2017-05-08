using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlinkBlink_EyeJoah.Chart.ConstantChange;

namespace BlinkBlink_EyeJoah
{
    public partial class Control1_Home : UserControl
    {
        ConstantChange con;
        public static Timer blinkTimer;
        public Control1_Home()
        {
            InitializeComponent();

            con = new ConstantChange();
            con.TopLevel = false;
            con.AutoScroll = true;
            blinkTimer = BlinkTimer;
            blinkTimer.Start();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.Controls.Add(con);
            con.Show();
        }

        public ConstantChange getConstantChange
        {
            get { return con; }
            set { con = value; }
        }

        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            // 여기다가 넣어주면 댐
            MessageBox.Show("7초동안 눈을 한 번도 안 깜빡였네");
        }
    }
}
