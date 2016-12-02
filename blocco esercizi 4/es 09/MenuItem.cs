using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_09
{
    public class MenuItem
    {
        private string name;

        public MenuItem(string name)
        {
            this.name = name;
        }

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

        public virtual string PrintToString()
        {
            return name;
            //Console.Write("{0} -",name);
        }
    }
}
