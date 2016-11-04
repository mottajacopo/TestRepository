using System;
using es_06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestEs06DecToHex()
        {
            Assert.AreEqual("0xc", Program.DecToHex("12"));
            Assert.AreEqual("0x41", Program.DecToHex("65"));
            Assert.AreEqual("0x0", Program.DecToHex("0"));
        }
        [TestMethod]
        public void TestEs06HexToDec()
        {
            Assert.AreEqual("42", Program.HexToDec("0x2a"));
            Assert.AreEqual("2748", Program.HexToDec("0xabc"));
            Assert.AreEqual("0", Program.HexToDec("0x0"));
        }

        [TestMethod]
        public void TestEs06DecToBin()
        {
            Assert.AreEqual("101100", Program.DecToBin("44"));
            Assert.AreEqual("111", Program.DecToBin("7"));
            Assert.AreEqual("0", Program.DecToBin("0"));
        }
        [TestMethod]
        public void TestEs06BinToDec()
        {
            Assert.AreEqual("26", Program.BinToDec("11010"));
            Assert.AreEqual("57", Program.BinToDec("111001"));
            Assert.AreEqual("0", Program.BinToDec("0"));
        }
    }
}
