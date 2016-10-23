using System;
using es_04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco4
{
    [TestClass]
    public class Es04Test
    {
        [TestMethod]
        public void TestEs04PronunciationOfNumbers()
        {
            string result;
            int numShort =  670;
            string  numString = "670";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual( "six hundred seventy " , result);

            numShort = 0;
            numString = "0";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual("zero", result);

            numShort = 318;
            numString = "318";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual("three hundred eighteen", result);

            numShort = 999;
            numString = "999";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual("nine hundred ninety nine", result);

            numShort = 400;
            numString = "400";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual("four hundred  ", result);

            numShort = 71;
            numString = "71";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual(" seventy one", result);

        }
    }
}
