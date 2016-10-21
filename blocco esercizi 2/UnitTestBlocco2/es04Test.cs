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
            Assert.AreEqual(result, "six hundred seventy ");

            numShort = 0;
            numString = "0";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual(result, "zero");

            numShort = 318;
            numString = "318";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual(result, "three hundred eighteen");

            numShort = 999;
            numString = "999";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual(result, "nine hundred ninety nine");

            numShort = 400;
            numString = "400";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual(result, "four hundred  ");

            numShort = 71;
            numString = "71";
            result = Program.pronunciationOfNumber(ref numShort, ref numString);
            Assert.AreEqual(result, " seventy one");

        }
    }
}
