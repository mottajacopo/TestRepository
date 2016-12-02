using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_08
{
    interface IPayable
    {
        int RetrieveAmount();
        int AddToAmount(int amountDue);
        string PaymentAddress {get; }
    }
}
