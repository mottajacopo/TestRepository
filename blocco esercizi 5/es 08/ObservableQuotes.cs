using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_08
{
        public class ObservableQuote : IObservable<Quote>
        {
            private List<IObserver<Quote>> observers = new List<IObserver<Quote>>();
            private Quote quote;
            public Quote Quote
            {
                get
                {
                    return quote;
                }
                set
                {
                    quote = value;
                    this.Notify(quote);
                }
            }

            private void Notify(Quote quote)
            {
                foreach (IObserver<Quote> observer in observers)
                {
                    if (quote.Symbol == null || quote.Price < 0)
                    {
                        observer.OnError(new ApplicationException("Bad Quote data"));
                    }
                    else
                    {
                        observer.OnNext(quote);
                    }
                }
            }

            private void Stop()
            {
                foreach (IObserver<Quote> observer in observers)
                {
                    if (observers.Contains(observer))
                    {
                        observer.OnCompleted();
                    }
                }
                observers.Clear();
            }


            public IDisposable Subscribe(IObserver<Quote> observer)
            {
                if (!observers.Contains(observer))
                {
                    observers.Add(observer);
                }
                return new Unsubscriber(observers, observer);
            }

            private class Unsubscriber : IDisposable
            {
                private List<IObserver<Quote>> observers;
                private IObserver<Quote> observer;

                public Unsubscriber(List<IObserver<Quote>> observers, IObserver<Quote> observer)
                {
                    this.observers = observers;
                    this.observer = observer;
                }
                public void Dispose()
                {
                    if (observer != null && observers.Contains(observer))
                    {
                        observers.Remove(observer);
                    }
                }
            }
        }
    }

