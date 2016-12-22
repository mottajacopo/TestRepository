using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_05
{
    public class Participant
    {
        
        int age;
        string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age 
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        
    }
}
