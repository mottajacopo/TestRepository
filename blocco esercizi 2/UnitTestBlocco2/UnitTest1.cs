using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es01Test
    {
        [TestMethod]
        public void TestGreater()
        {
            bool result;
            result = es_01.Program.greater(3, 5);
            Assert.AreEqual(result, false);
            result = es_01.Program.greater(5, 3);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TestSmaller()
        {
            bool result;
            result = es_01.Program.smaller(8, 9);
            Assert.AreEqual(result, true);
            result = es_01.Program.smaller(9, 8);
            Assert.AreEqual(result, false);

        }
    }
}
