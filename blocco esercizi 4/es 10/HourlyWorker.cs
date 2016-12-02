using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_10
{
    public class HourlyWorker : Employee
    {
        decimal hourlyRate;
        decimal hourWorked;

        public HourlyWorker(string empName , decimal hourlyRate, decimal hourWorked) : base(empName)
        {
            this.hourlyRate = hourlyRate;
            this.hourWorked = hourWorked;
        }

        public decimal HourlyRate
        {
            get
            {
                return this.hourlyRate;
            }
            set
            {
                this.hourlyRate = value;
            }
        }

        public decimal HourWorked
        {
            get
            {
                return this.hourWorked;
            }
            set
            {
                this.hourWorked = value;
            }
        }

        public override decimal calcPaidCheck()
        {
            return base.calcPaidCheck() + (hourWorked * hourlyRate);
        }
    }
}
