using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_05;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es05Test
    {
        [TestMethod]
        public void TestEs05Factor()
        {
            int factor = Program.factorial(5);
            Assert.AreEqual(factor, 120);
        }
        [TestMethod]
        public void TestEs05Exp()
        {
            int exp = Program.exponential(2, 5);
            Assert.AreEqual(exp, 32);
        }
        [TestMethod]
        public void TestEs05Sum()
        {
            int sum = Program.calculate(1, 3);
            Assert.AreEqual(sum, 10);

        }
    }
        
}
