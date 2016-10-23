using System;
using es_08;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es08Test
    {
        [TestMethod]
        public void TestEs08GCD()
        {
            int result;
            result = Program.GCD(-12, 8);
            Assert.AreEqual( 4, result);

            result = Program.GCD(13, 4);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestEs08LCM()
        {
            int result;
            result = Program.LCM(-12, 8, 4);
            Assert.AreEqual(24, result);

            result = Program.LCM(13, 4, 1);
            Assert.AreEqual(52, result);

        }
    }
}
