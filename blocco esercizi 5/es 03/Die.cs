using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_03
{
    public delegate void Notifier();
    public class Die
    {
        private int number;
        static private Random randomNumberSupplier = new Random((int)DateTime.Now.Ticks);
        private const int maxNumberOfEyes = 6;        
        public event Notifier twoSixesInARow = delegate { };
        bool x = true;
        int lastToss;
        int secondLastToss;

        public Die()
        {
            Toss();
        }

        public void Toss()
        {
            number = NewToss();
            if (x)
            {
                lastToss = number;
                x = false;
            }
            else
            {
                secondLastToss = number;
                x = true;
            }

            if (TwoSixesInARow(lastToss , secondLastToss))
            {
                twoSixesInARow();
            }
        }
      
        public bool TwoSixesInARow(int lastToss , int secondLastToss)
        {
            if (lastToss == 6 && secondLastToss == 6)
            {
                return true;
            }
            return false;
       }
     
        private int NewToss()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int Number()
        {
            return number;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", number);
        }
    }

}
