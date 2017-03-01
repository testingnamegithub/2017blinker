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
    public partial class Control4_Settings : UserControl
    {

        private Settings_Scroll settingsControl;

        //외부 클래스에서 접근하도록 하는 객체
        public static Control4_Settings control4_settings;

        public Control4_Settings()
        {
            InitializeComponent();

            settingsControl = new Settings_Scroll();
            settingsControl.Dock = DockStyle.Fill;
            scrollPanel.Controls.Add(settingsControl);

            control4_settings = this; //객체 가르키기

        }

        //외부 클래스에서 점근할 메서드-  비디오박스 컨텐츠 수정
        public void updateVideo(Image videoImage)
        {
            videoBox.Image = videoImage;
        }
        public void emptyVideo()
        {
            videoBox.Image = null;
        }
    }
}