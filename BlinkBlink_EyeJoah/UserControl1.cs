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
    public partial class UserControl1 : UserControl
    {
        ConstantChange con;
        public UserControl1()
        {
            InitializeComponent();

            con = new ConstantChange();
            con.TopLevel = false;
            con.AutoScroll = true;
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
    }
}
