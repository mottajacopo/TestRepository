using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_08
{
    public class ObserverIBM : IObserver<Quote>
    {
        public int numQuotesReceived = 0;
        public bool isComplete = false;
        public bool isError = false;
        public Quote lastQuote = null;
        public void OnCompleted()
        {
            isComplete = true;
        }

        public void OnError(Exception error)
        {
            isError = true;
        }

        public void OnNext(Quote value)
        {
            if (value.Symbol == "IBM")
            {
                lastQuote = value;
                numQuotesReceived++;
            }
        }
    }
}
