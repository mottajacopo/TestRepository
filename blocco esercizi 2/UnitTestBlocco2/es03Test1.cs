using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_03;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es03Test
    {
        [TestMethod]
        public void TestRoots()
        {
            int result ;
            double root1 = 0;
            double root2 = 0;
            result = Program.roots(1, -4 , 4 , ref root1 , ref root2);
            Assert.AreEqual(result, 1);
            Assert.AreEqual(root1, 2);

            result = Program.roots(1, -4, 6, ref root1, ref root2);
            Assert.AreEqual(result, 0);

            result = Program.roots(1, 2, -8, ref root1, ref root2);
            Assert.AreEqual(result, 2);
            Assert.AreEqual(root1, 2);
            Assert.AreEqual(root2, -4);




        }

    }
}
