using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_09;

namespace UnitTestBlocco4
{
    [TestClass]
    public class TestMenu
    {
        [TestMethod]

        public void TestPrintMenu()
        {
            MenuItem[] menu = new MenuItem[]
                {
                new Beverage("Acqua", 0.30M, 0.50M, 1),
                new Beverage("Coca Cola", 1.50M, 2.50M, 3.50M),
                new Beverage("Fanta", 1.50M, 2.50M, 3.50M),
                new Beverage("Caffe", 0.30M, 0.50M, 1),
                new Snack("Cracker", 0.50M),
                new Snack("Chocolate bar", 1.50M),
                new Snack("Biscuit", 1)
                };

            Assert.AreEqual("Acqua - small : $ 0,30- medium : $ 0,50- large : $ 1", menu[0].PrintToString());
            Assert.AreEqual("Coca Cola - small : $ 1,50- medium : $ 2,50- large : $ 3,50", menu[1].PrintToString());
            Assert.AreEqual("Fanta - small : $ 1,50- medium : $ 2,50- large : $ 3,50", menu[2].PrintToString());
            Assert.AreEqual("Caffe - small : $ 0,30- medium : $ 0,50- large : $ 1", menu[3].PrintToString());
            Assert.AreEqual("Cracker - price : $ 0,50", menu[4].PrintToString());
            Assert.AreEqual("Chocolate bar - price : $ 1,50", menu[5].PrintToString());
            Assert.AreEqual("Biscuit - price : $ 1" , menu[6].PrintToString());

        }
    }
}