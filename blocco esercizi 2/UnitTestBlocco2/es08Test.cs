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
            Assert.AreEqual(result, 4);

            result = Program.GCD(13, 4);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestEs08LCM()
        {
            int result;
            result = Program.LCM(-12, 8, 4);
            Assert.AreEqual(result, 24);
            result = Program.LCM(13, 4, 1);
            Assert.AreEqual(result, 52);

        }
    }
}
