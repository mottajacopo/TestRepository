using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_10;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es10Test
    {
        [TestMethod]
        public void TestWordPosition()
        {
            string input = "Per fare un tavolo ci vuole il legno, per fare il legno ci vuole l albero, per fare l albero ci vuole il seme...";

            object[,] words = Program.AlphabeticalOrder(input);

            Assert.AreEqual("albero", words[0, 0]);
            Assert.AreEqual("seme", words[0, 7]);
            Assert.AreEqual("vuole", words[0, 10]);

        }

        [TestMethod]
        public void TestWordNumber()
        {
            string input = "Per fare un tavolo ci vuole il legno, per fare il legno ci vuole l albero, per fare l albero ci vuole il seme...";

            object[,] words = Program.AlphabeticalOrder(input);

            Assert.AreEqual(2, words[1, 0]);
            Assert.AreEqual(1, words[1, 7]);
            Assert.AreEqual(3, words[1, 10]);

        }
    }
}
