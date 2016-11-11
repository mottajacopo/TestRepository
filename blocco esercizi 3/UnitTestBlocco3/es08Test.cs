using System;
using es_08;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es08Test
    {
        [TestMethod]
        public void TestEncode()
        {
            string input = "Test";
            string cipher = "ab";
            string encoded = Encode(input, cipher);
            string resultExpected = "\\u0035\\u0007\\u0012\\u0016";
            Assert.AreEqual(resultExpected, encoded);
        }
    }
}
