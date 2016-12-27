using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using es_08;

namespace UnitTestBlocco8
{
    [TestClass]
    public class TestEs08Quotes
    {
        [TestMethod]
        public void TestObserver()
        {
            ObservableQuote oq = new ObservableQuote();
            ObserverIBM ObserverIBM = new ObserverIBM();
            ObserverDELL ObserverDELL = new ObserverDELL();
            IEnumerable<Quote> quotes = new QuoteRepository().GetAllQuotes();
            using (oq.Subscribe(ObserverIBM))
            {
                using (oq.Subscribe(ObserverDELL))
                {
                    foreach (Quote quote in quotes)
                    {
                        oq.Quote = quote;
                    }
                }
            }
            Assert.AreEqual(5, ObserverIBM.numQuotesReceived);
            Assert.AreEqual(3, ObserverDELL.numQuotesReceived);
        }
    }
}
