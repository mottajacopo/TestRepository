using System;
using es_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es01Test
    {
        [TestMethod]
        public void TestEs01Greater()
        {
            int result;
            result = Program.greater(3, 5);
            Assert.AreEqual(result, 5);
            result = Program.greater(-4, 12);
            Assert.AreEqual(result, 12);
        }

        [TestMethod]
        public void TestEs01Smaller()
        {
            int result;
            result = Program.smaller(3, 5);
            Assert.AreEqual(result, 3);
            result = Program.smaller(-4, 12);
            Assert.AreEqual(result, -4);

        }
    }
}
