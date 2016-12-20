using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_01
{
    public class BusTax : Bus, ITaxable
    {
        public BusTax(int numberOfSeats, int regNumber, decimal value) :
          base(numberOfSeats, regNumber, value)
        {
        }

        public decimal Taxable()
        {
            return (value / (numberOfSeats * 5) );
        }
    }
}
