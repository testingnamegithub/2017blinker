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
using System.IO;
using System.Reflection;
using System.Media;

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

            //string pathToSound = Assembly.GetExecutingAssembly().Location; // returns the full path to Application.exe is
            //pathToSound = Path.GetDirectoryName(pathToSound); // returns the directory where Application.exe (and file.wav) are. 
            //pathToSound = Path.Combine(pathToSound, "facebook_sound.wav"); // combines the directory name with file.wav. 
            SoundPlayer sound = new SoundPlayer("C:\\facebook_sound.wav"); // loads the file. 
            sound.Play(); // plays the file. 

            //Thread.Sleep(3000);

            //colorChange.changeScreenOriginal();
        }
    }
}
