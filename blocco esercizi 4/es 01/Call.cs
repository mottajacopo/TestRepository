using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    class Call
    {
        int date = 0;
        int startTime = 0;
        int duration = 0;

        public Call(int date ,int startTime , int duration)
        {
            this.date = date;
            this.startTime = startTime;
            this.duration = duration;
        }

        public int Date
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

        public int StartTime
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
