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
            
            int result;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            result = Program.GreaterThanNeighbours(array, 10, 4);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestFindGreaterThanNeighboursTrue()
        {

            int result;
            int[] array = { 1, 2, 3, 4, 7, 5, 7, 8, 9, 10 };

            result = Program.GreaterThanNeighbours(array, 10, 4);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestFindGreaterThanNeighboursTrueFirst()
        {

            int result;
            int[] array = { 1, 0, 3, 4, 5, 6, 7, 8, 9, 10 };

            result = Program.GreaterThanNeighbours(array, 10, 0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestFindGreaterThanNeighboursTrueLast()
        {

            int result;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            result = Program.GreaterThanNeighbours(array, 10, 9);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void FindFirstOccurrence()
        {
            int index;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            index = Program.FindFirstOccurrence(array, 10);

            Assert.AreEqual(9, index);

            int[] array2 = { 1, 2, 6, 4, 5, 6, 7, 8, 9, 10 };

            index = Program.FindFirstOccurrence(array2, 10);

            Assert.AreEqual(2, index);
        }
    }
}
