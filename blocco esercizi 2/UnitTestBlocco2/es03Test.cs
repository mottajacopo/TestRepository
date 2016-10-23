using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_03;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es03Test
    {
        [TestMethod]
        public void TestEs03Roots()
        {
            int result;
            double root1 = 0;
            double root2 = 0;

            result = Program.roots(1, -4 , 4 , ref root1 , ref root2);
            Assert.AreEqual(1, result);
            Assert.AreEqual(2, root1);

            result = Program.roots(1, -4, 6, ref root1, ref root2);
            Assert.AreEqual(0, result);

            result = Program.roots(1, 2, -8, ref root1, ref root2);
            Assert.AreEqual(2, root1);
            Assert.AreEqual(-4, root2);
        }
    }
}
