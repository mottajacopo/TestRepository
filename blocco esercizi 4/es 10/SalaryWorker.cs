using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_10
{
    public class SalaryWorker : Employee
    {
        decimal annualSalary;

        public SalaryWorker(string empName, decimal annualSalary) : base(empName)
        {
            this.annualSalary = annualSalary;
        }

        public decimal AnnualSalary
        {
            get
            {
                return this.annualSalary;
            }
            set
            {
                this.annualSalary = value;
            }
        }

        public override decimal calcPaidCheck()
        {
            return base.calcPaidCheck() + (annualSalary/12);
        }
    }
}
