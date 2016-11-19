using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    public class Call
    {
        string date = null;
        string startTime = null;
        int duration = 0;

        public Call(string date, string startTime, int duration)
        {
            this.date = date;
            this.startTime = startTime;
            this.duration = duration;
        }
        public Call()
          : this(null, null , 0) { }
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public string StartTime
        {
            get
            {
                return this.startTime;
            }
            set
            {
                this.startTime = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
    }
}
