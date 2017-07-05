using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlinkBlink_EyeJoah
{
    class ResizeImage
    {
        
        public static Bitmap adjust(Bitmap image, Size newSize)
        {
            Bitmap newImage = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage((System.Drawing.Image)newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newSize.Width, newSize.Height);
            }
            return newImage;
        }
    }
}
