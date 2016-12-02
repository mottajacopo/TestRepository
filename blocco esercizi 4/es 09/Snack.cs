using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_09
{
    public class Snack : MenuItem
    {
        decimal price;

        public Snack(string name , decimal price ) : base(name)
        {
            this.price = price;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public override string PrintToString()
        {
            base.PrintToString();
            string snack = (" - price : $ " + Price);
            return (base.PrintToString() + snack);
        }
    }
}
