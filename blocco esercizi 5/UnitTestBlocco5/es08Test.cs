using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using es_08;

namespace UnitTestBlocco5
{
    [TestClass]
    public class TestEs08Quotes
    {
        [TestMethod]
        public void TestEs08QuoteObserverIBM()
        {
            ObservableQuote observableQuote = new ObservableQuote();
            ObserverIBM IBM = new ObserverIBM();
            IEnumerable<Quote> quotes = new QuoteRepository().GetAllQuotes();
            List<Quote> quotesList = quotes.ToList();

            observableQuote.Subscribe(IBM);
            observableQuote.QuoteAddList(quotesList, "IBM");

            Assert.AreEqual(false, IBM.CompletedBool);
            Assert.AreEqual(true, IBM.NextBool);
            Assert.AreEqual(true, IBM.ErrorBool);

        }
        [TestMethod]
        public void TestEs08QuoteObserverDELL()
        {
            ObservableQuote observableQuote = new ObservableQuote();
            ObserverDELL DELL = new ObserverDELL();
            IEnumerable<Quote> quotes = new QuoteRepository().GetAllQuotes();
            List<Quote> quotesList = quotes.ToList();

            observableQuote.Subscribe(DELL);
            observableQuote.QuoteAddList(quotesList, "DELL");

            Assert.AreEqual(false, DELL.CompletedBool);
            Assert.AreEqual(true, DELL.NextBool);
            Assert.AreEqual(true, DELL.ErrorBool);

        }
    }
}