using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;

namespace BlinkBlink_EyeJoah
{
    class ScreenColorChange
    {
        private static ScreenColorChange screenColorChange;
        public static ScreenColorChange getInstance()
        {
            if (screenColorChange == null)
            {
                screenColorChange = new ScreenColorChange();
            }
            return screenColorChange;
        }

        public void changeScreenColor(string color)
        {
            setLCDbrightness(255, 198, 176);
        }

        public void changeScreenOriginal()
        {
            setLCDbrightness(255, 255, 255);
        }

        [DllImport("GDI32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(IntPtr hdc, void* ramp);
        private static IntPtr hdc;

        public unsafe bool setLCDbrightness(short red, short green, short blue)
        {
            Graphics gg = Graphics.FromHwnd(IntPtr.Zero);
            hdc = gg.GetHdc();

            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;
            short brightness = 0;
            for (int j = 0; j < 3; j++)
            {
                if (j == 0) brightness = red;
                if (j == 1) brightness = green;
                if (j == 2) brightness = blue;
                for (int i = 0; i < 256; i++)
                {
                    int arrayVal = i * (brightness);
                    if (arrayVal > 65535) arrayVal = 65535;
                    *idx = (short)arrayVal;
                    idx++;
                }
            }
            // For some reason, this always returns false?
            bool retVal = SetDeviceGammaRamp(hdc, gArray);
            gg.Dispose();
            return false;
        }
    }
}
