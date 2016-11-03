using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_03;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es03Test
    {
       
        [TestMethod]
        public void TestEs03ZeroSolution()
        {
            int result;
            double root1 = 0;
            double root2 = 0;

            result = Program.Roots(1, -4, 6, ref root1, ref root2);
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void TestEs03TwoSolution()
        {
            int result;
            double root1 = 0;
            double root2 = 0;

            result = Program.Roots(1, 2, -8, ref root1, ref root2);
            Assert.AreEqual(2, result);
            Assert.AreEqual(2, root1);
            Assert.AreEqual(-4, root2);

        }

        [TestMethod]
        public void TestEs03OneSolution()
        {
            int result;
            double root1 = 0;
            double root2 = 0;

            result = Program.Roots(1, -4, 4, ref root1, ref root2);
            Assert.AreEqual(1, result);
            Assert.AreEqual(2, root1);

        }
    }
}
