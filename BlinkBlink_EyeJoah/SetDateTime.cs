using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkBlink_EyeJoah
{
    class DateTimeLabelSettings
    {
        //singleton pattern
        private static DateTimeLabelSettings dateTimeLabelSettings;
        public static DateTimeLabelSettings getInstance()
        {
            if (dateTimeLabelSettings == null)
            {
                dateTimeLabelSettings = new DateTimeLabelSettings();
            }
            return dateTimeLabelSettings;
        }

        string fullDateString;
        string strDay;
        string strMonth;
        string intDay;
        string intyear;


        public string createDateString()
        {
            DateTime now = DateTime.Now;

            //요일
            strDay = now.ToString("dddd",new CultureInfo("en-US"));
            //월
            strMonth = now.ToString("MMMM",new CultureInfo("en-US"));
            //일
            intDay = now.ToString("dd");
            //년
            intyear = now.ToString("yyyy", new CultureInfo("en-US"));

            fullDateString = strMonth + " " + intDay + ", " + intyear + " (" + strDay + ")";

            return fullDateString;
        } 



       


    }
}
