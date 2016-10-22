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
            float result;
            result = Program.greater(3.2F ,5);
            Assert.AreEqual(result, 5);
            result = Program.greater(-4, 12.6F);
            Assert.AreEqual(result, 12.6F);
        }

        [TestMethod]
        public void TestEs01Smaller()
        {
            float result;
            result = Program.smaller(3.2F, 5);
            Assert.AreEqual(result, 3.2F);
            result = Program.smaller(-4, 12.6F);
            Assert.AreEqual(result, -4);
        }
    }
}
