using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_09
{
    public class Beverage : MenuItem
    {
        decimal small;
        decimal medium;
        decimal large;

        public Beverage(string name ,decimal small, decimal medium, decimal large) : base(name)
        {
            this.small = small;
            this.medium = medium;
            this.large = large;
        }

        public decimal Small
        {
            get
            {
                return this.small;
            }
            set
            {
                this.small = value;
            }
        }

        public decimal Medium
        {
            get
            {
                return this.medium;
            }
            set
            {
                this.medium = value;
            }
        }

        public decimal Large
        {
            get
            {
                return this.large;
            }
            set
            {
                this.large = value;
            }
        }

        public override string PrintToString()
        {
            string beverage = " - small : $ " + Small + "- medium : $ " + Medium + "- large : $ " + Large;
            return (base.PrintToString() + beverage);
        }
    }
}
