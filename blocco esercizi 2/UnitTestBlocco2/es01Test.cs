using System;
using es_01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es01Test
    {
        [TestMethod]
        public void TestEs01Greater()
        {
            float result;
            result = Program.greater( 5 , 3.2F);
            Assert.AreEqual(5 ,result);
            result = Program.greater(12.6F , -4);
            Assert.AreEqual( 12.6F ,result);
            result = Program.greater(0, 44);
            Assert.AreEqual(44, result);
        }


        [TestMethod]
        public void TestEs01Smaller()
        {
            float result;
            result = Program.smaller(3.2F, 5);
            Assert.AreEqual(3.2F, result);
            result = Program.smaller(-4, 12.6F);
            Assert.AreEqual( -4, result);
            result = Program.smaller(0, 44);
            Assert.AreEqual( 0, result);
        }
    }
}


