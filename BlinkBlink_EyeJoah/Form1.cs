using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlinkBlink_EyeJoah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            homePanel.BringToFront();
            homePanel.Show();
            //homePanel.Visible = true;
            //blinkPanel.Visible = false;
          
            //blinkPanel.SendToBack();
 
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            blinkPanel.BringToFront();

            blinkPanel.Show();
            //homePanel.Visible = false;
            //blinkPanel.Visible = true;
            //homePanel.SendToBack();
        }
    }
}
