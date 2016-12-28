using System;
using System.Collections.Generic;

namespace es_08
{
    public class ObserverDELL : IObserver<Quote>
    {
        public bool CompletedBool { get; set; }
        public bool ErrorBool { get; set; }
        public bool NextBool { get; set; }

        public void OnCompleted()
        {
            CompletedBool = true;
        }

        public void OnError(Exception error)
        {
            ErrorBool = true;
        }

        public void OnNext(Quote value)
        {
            NextBool = true;
        }
    }
}