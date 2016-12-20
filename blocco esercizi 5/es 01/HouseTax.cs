using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    public class HouseTax : House, ITaxable
    {

        public HouseTax(string location, bool inCity, double area, decimal value) :
          base(location, inCity, area, value)
        {
        }

        public decimal Taxable()
        {
            if (inCity == true)
            {
                return (estimatedValue / (decimal)area) * 1.2M;
            }
            else
            {
                return (estimatedValue / (decimal)area);
            }
        }
    }
}
