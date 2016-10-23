using System;
using es_06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es06Test
    {
        [TestMethod]
        public void TestEs06FromDecToBin()
        {
            string result;
            result = Program.fromDecToBin("13");
            Assert.AreEqual("1101", result);

            result = Program.fromDecToBin("0");
            Assert.AreEqual("0", result);

            result = Program.fromDecToBin("23c4f");
            Assert.AreEqual("Impossibile! Il numero inserito non è decimale.", result);
        }

        [TestMethod]
        public void TestEs06FromBinToDec()
        {
            string result;
            result = Program.fromBinToDec("1110101");
            Assert.AreEqual("117", result);

            result = Program.fromBinToDec("452");
            Assert.AreEqual("Impossibile! Il numero inserito non è binario.", result);
        }

        [TestMethod]
        public void TestEs06FromHexToDec()
        {
            string result;
            result = Program.fromHexToDec("c3b0");
            Assert.AreEqual("50096", result);

            result = Program.fromHexToDec("65ad");
            Assert.AreEqual("26029", result);
        }

        [TestMethod]
        public void TestEs06FromDecToHex()
        {
            string result;
            result = Program.fromDecToHex("1002");
            Assert.AreEqual("3EA", result);

            result = Program.fromDecToHex("58f");
            Assert.AreEqual("Impossibile! Il numero inserito non è decimale.", result);
        }
    }
}
