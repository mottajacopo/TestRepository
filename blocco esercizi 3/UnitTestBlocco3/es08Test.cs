using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_08;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es08Test
    {
        [TestMethod]
        public void TestEncode()
        {
            string message = "Questa è una prova";
            string cipher = "test";
            string encoded = Program.Encode(message, cipher);
            string resultExpected = "\\u0025\\u0010\\u0016\\u0007\\u0000\\u0004\\u0053\\u009c\\u0054\\u0010\\u001d\\u0015\\u0054\\u0015\\u0001\\u001b\\u0002\\u0004";
            Assert.AreEqual(resultExpected, encoded);
        }

        [TestMethod]
        public void TestEncode2()
        {
            string message = "Messaggio da criptare";
            string cipher = "codice";
            string encoded = Program.Encode(message, cipher);
            string resultExpected = "\\u002e\\u000a\\u0017\\u001a\\u0002\\u0002\\u0004\\u0006\\u000b\\u0049\\u0007\\u0004\\u0043\\u000c\\u0016\\u0000\\u0013\\u0011\\u0002\\u001d\\u0001";
            Assert.AreEqual(resultExpected, encoded);
        }
    }
}
