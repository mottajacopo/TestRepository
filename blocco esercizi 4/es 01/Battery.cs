using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    public enum Technology { LiIon, NiMH, NiCd }
    public class Battery
    {
        private string model = null;
        private int talkTime = 0;
        private int idleTime = 0;
        private Technology type;


        public Battery(string model, int talkTime, int idleTime, Technology type = Technology.LiIon)
        {
            this.model = model;
            this.idleTime = idleTime;
            this.talkTime = talkTime;
            this.type = type;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int IdleTime
        {
            get
            {
                return this.idleTime;
            }
            set
            {
                this.idleTime = value;
            }
        }

        public int TalkTime
        {
            get
            {
                return this.talkTime;
            }
            set
            {
                this.talkTime = value;
            }
        }

        public Technology Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

    }
}