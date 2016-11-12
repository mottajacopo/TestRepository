using System;
using es_01;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es01Test
    {
        [TestMethod]
        public void TestFindGreaterThanNeighboursFalse()
        {
            
            bool result;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            result = Program.GreaterThanNeighbours(array, 10, 4);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestFindGreaterThanNeighboursTrue()
        {

            bool result;
            int[] array = { 1, 2, 3, 4, 7, 5, 7, 8, 9, 10 };

            result = Program.GreaterThanNeighbours(array, 10, 4);
            Assert.AreEqual(true, result);
        }
    }
}
