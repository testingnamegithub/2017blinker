using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkBlink_EyeJoah
{
    class CalendarDate
    {
        //singleton pattern
        private static CalendarDate calendarDate;
        public static CalendarDate getInstance()
        {
            if (calendarDate == null)
            {
                calendarDate = new CalendarDate();
            }
            return calendarDate;
        }

        public int Day(DateTime date)
        {
            return date.Day;
        }

        public string Month(DateTime date)
        {
            return date.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-US"));
        }

        public int Year(DateTime date)
        {
            return date.Year;
        }

        public string DayOfWeek(DateTime date)
        {
            return date.ToString("dddd", CultureInfo.CreateSpecificCulture("en-US"));
        }

    }
}
