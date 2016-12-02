using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using es_07;

namespace es_08
{
    public class Employee : Person, IPayable
    {
        private int Salary { get; }
        private string MailingAddress { get; }
        
        public Employee(string firstName, string lastName, DateTime dateOfBirth, int salary, string mailingAddress)
            : base(firstName, lastName, dateOfBirth)
        {
            Salary = salary;
            MailingAddress = mailingAddress;
        }

        public string PaymentAddress
        {
            get
            {
                return this.MailingAddress;
            }
        }
        public int AddToAmount(int amountDue)
        {
            return amountDue + Salary;
        }
        public int RetrieveAmount()
        {
            return Salary;
        }
    }
}
