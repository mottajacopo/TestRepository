using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_09;

namespace UnitTestBlocco3
{

    [TestClass]
    public class es09Test
    {
        [TestMethod]
        public void TestMailFinder()
        {
            string file = " Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
            string result = Program.ExtractEmails(file);
            string test = "example@gmail.com\r\ntest.user@yahoo.co.uk\r\na@a.b\r\n";
            Assert.AreEqual(test, result);
        }

    }
}
