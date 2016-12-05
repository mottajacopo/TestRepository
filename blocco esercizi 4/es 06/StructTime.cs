using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_06
{
    public struct Time
    {
        private readonly int minutes;
        
        public Time(int hh, int mm)
        {
            this.minutes = 60 * hh + mm;
        }
        public override String ToString()
        {
            String result = string.Format("{0:00}:{1:00}", Hour, Minute);
            return result;

        }
        public int Hour
        {
            get
            {
                return minutes / 60;
            }
        }
        public int Minute
        {
            get
            {
                return minutes % 60;
            }
        }
        static public Time operator+(Time time1, Time time2)
        {
            int hours = time1.Hour + time2.Hour;
            int min = time1.Minute + time2.Minute;
            return new Time(hours, min);
        }
        static public Time operator-(Time time1, Time time2)
        {
            int hours = time1.Hour - time2.Hour;
            int min = time1.Minute - time2.Minute;
            return new Time(hours, min);
        }
        static public implicit operator Time(int totalMinutes)
        {
            Time timeConverted = new Time(totalMinutes / 60, totalMinutes % 60);
            return timeConverted;
        }
        static public explicit operator int (Time time)
        {
            return time.minutes;
        }

    }
}
