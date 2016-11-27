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
        static public Time operator+(Time t1, Time t2)
        {
            Time result = new Time((t1.minutes + t2.minutes) / 60, (t1.minutes + t2.minutes) % 60);
            return result;
        }
        static public Time operator-(Time t1, Time t2)
        {
            Time result = new Time((t1.minutes - t2.minutes) / 60, (t1.minutes - t2.minutes) % 60);
            return result;
        }
        static public implicit operator Time(int totalMinutes)
        {
            Time timeConverted = new Time(totalMinutes / 60, totalMinutes % 60);
            return timeConverted;
        }
        static public explicit operator int (Time t)
        {
            return t.minutes;
        }

    }
}
