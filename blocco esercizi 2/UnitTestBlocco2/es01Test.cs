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
            result = Program.Greater( 8 , 3.2F);
            Assert.AreEqual(8 ,result);
        }

        public void TestEs01GreaterEqual()
        {
            float result;
            result = Program.Greater(5, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestEs01Smaller()
        {
            float result;
            result = Program.Smaller(3.2F, 5);
            Assert.AreEqual(3.2F, result);  
        }

        [TestMethod]
        public void TestEs01SmallerEqual()
        {
            float result;
            result = Program.Smaller(9, 9);
            Assert.AreEqual(9, result);
        }
    }
}


