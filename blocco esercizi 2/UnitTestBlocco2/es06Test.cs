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
            Assert.AreEqual(result, "1101");

            result = Program.fromDecToBin("0");
            Assert.AreEqual(result, "0");

            result = Program.fromDecToBin("23c4f");
            Assert.AreEqual(result, "Impossibile! Il numero inserito non è decimale.");

        }

        [TestMethod]
        public void TestEs06FromBinToDec()
        {
            string result;
            result = Program.fromBinToDec("1110101");
            Assert.AreEqual(result, "117");

            result = Program.fromBinToDec("452");
            Assert.AreEqual(result, "Impossibile! Il numero inserito non è binario.");

        }
    }
}
