using System;
using es_06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestDecToBin()
        {
            Assert.AreEqual("0", Program.DecToBin("0"));
            Assert.AreEqual("1", Program.DecToBin("1"));
            Assert.AreEqual("1000", Program.DecToBin("8"));
        }
        [TestMethod]
        public void TestBinToDec()
        {
            Assert.AreEqual("0", Program.BinToDec("0"));
            Assert.AreEqual("1", Program.BinToDec("1"));
            Assert.AreEqual("3", Program.BinToDec("11"));
        }
        [TestMethod]
        public void TestDecToHex()
        {
            Assert.AreEqual("0x0", Program.DecToHex("0"));
            Assert.AreEqual("0xa", Program.DecToHex("10"));
            Assert.AreEqual("0x100", Program.DecToHex("256"));
        }
        [TestMethod]
        public void TestHexToDec()
        {
            Assert.AreEqual("0", Program.HexToDec("0x0"));
            Assert.AreEqual("10", Program.HexToDec("0xa"));
            Assert.AreEqual("256", Program.HexToDec("0x100"));
        }

    }
}
