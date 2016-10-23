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
            result = Program.greater(3.2F, 5);
            Assert.AreEqual(result, 5);
            result = Program.greater(-4, 12.6F);
            Assert.AreEqual(result, 12.6F);
            result = Program.greater(0, 44);
            Assert.AreEqual(result, 44);
        }


        [TestMethod]
        public void TestEs01Smaller()
        {
            float result;
            result = Program.smaller(3.2F, 5);
            Assert.AreEqual(result, 3.2F);
            result = Program.smaller(-4, 12.6F);
            Assert.AreEqual(result, -4);
            result = Program.smaller(0, 44);
            Assert.AreEqual(result, 0);
        }
    }
}


