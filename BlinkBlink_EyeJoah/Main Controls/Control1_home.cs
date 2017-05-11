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
using System.Threading;

namespace BlinkBlink_EyeJoah
{
    public partial class Control1_Home : UserControl
    {
        public static Boolean convertOriginalColor = false;
        ScreenColorChange colorChange;
        ConstantChange con;
        public static System.Windows.Forms.Timer blinkTimer;
        public Control1_Home()
        {
            InitializeComponent();

            con = new ConstantChange();
            con.TopLevel = false;
            con.AutoScroll = true;
            blinkTimer = BlinkTimer;
            blinkTimer.Start();

            colorChange = ScreenColorChange.getInstance();
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
            convertOriginalColor = true;

            colorChange.changeScreenColor("color");

            Thread.Sleep(3000);

            colorChange.changeScreenOriginal();
        }
    }
}
