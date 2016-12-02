using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_10
{
    public class Employee
    {
        private string empName;

        public Employee(string empName)
        {
            this.empName = empName;
        }

        public string EmpName
        {
            get
            {
                return this.empName;
            }
            set
            {
                this.empName = value;
            }
        }

        public virtual decimal calcPaidCheck()
        {
            return 0;
        }
    }
}
