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
            double factor = Program.factorial(5);
            Assert.AreEqual(factor, 120);
        }
        [TestMethod]
        public void TestEs05Exp()
        {
            double exp = Program.exponential(2, 5);
            Assert.AreEqual(exp, 32);
        }
        [TestMethod]
        public void TestEs05Sum()
        {
            double sum;
            sum = Program.calculate(1, 3);
            Assert.AreEqual(sum, 10);
            sum = Program.calculate(-4, 5);
            Assert.AreEqual(sum, 0.7578125);

        }
    }
        
}
