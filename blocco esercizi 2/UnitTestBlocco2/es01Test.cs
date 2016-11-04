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
            int result;
            result = Program.Greater( 8 , 3);
            Assert.AreEqual(8 ,result);
        }

        [TestMethod]
        public void TestEs01GreaterEqual()
        {
            int result;
            result = Program.Greater(5, 5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestEs01Smaller()
        {
            int result;
            result = Program.Smaller(3, 5);
            Assert.AreEqual(3, result);  
        }

        [TestMethod]
        public void TestEs01SmallerEqual()
        {
            int result;
            result = Program.Smaller(9, 9);
            Assert.AreEqual(9, result);
        }
    }
}


