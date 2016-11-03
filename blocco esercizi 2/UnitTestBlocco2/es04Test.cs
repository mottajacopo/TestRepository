using System;
using es_04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco4
{
    [TestClass]
    public class Es04Test
    {
        [TestMethod]
        public void TestEs04SixHundredSeventy()
        {
            string result;
            int num = 670;
            string numString = "670";
            result = Program.PronunciationOfNumber(ref num, ref numString);
            Assert.AreEqual("six hundred seventy ", result);
        }

        [TestMethod]
        public void TestEs04Zero()
        {
            string result;
            int num = 0;
            string numString = "0";
            result = Program.PronunciationOfNumber(ref num, ref numString);
            Assert.AreEqual("zero", result);
        }

        [TestMethod]
        public void TestEs04ThreeHundredEighteen()
        {
            string result;
            int num = 318;
            string numString = "318";
            result = Program.PronunciationOfNumber(ref num, ref numString);
            Assert.AreEqual("three hundred eighteen", result);
        }
        [TestMethod]
        public void TestEs04NineHundredNinetyNine()
        {
            string result;
            int num = 999;
            string numString = "999";
            result = Program.PronunciationOfNumber(ref num, ref numString);
            Assert.AreEqual("nine hundred ninety nine", result);
        }

        [TestMethod]
        public void TestEs04FourHundred()
        {
            string result;
            int num = 400;
            string numString = "400";
            result = Program.PronunciationOfNumber(ref num, ref numString);
            Assert.AreEqual("four hundred  ", result);
        }

        [TestMethod]
        public void TestEs04SeventyOne()
        {
            string result;
            int num = 71;
            string numString = "71";
            result = Program.PronunciationOfNumber(ref num, ref numString);
            Assert.AreEqual(" seventy one", result);
        }
    }
}
