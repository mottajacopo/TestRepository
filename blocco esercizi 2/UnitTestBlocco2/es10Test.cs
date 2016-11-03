using System;
using es_10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es10Test
    {
        [TestMethod]
        public void TestEs10FunctionA()
        {
            int[,] matrixTest = { {1,4,7}, {2,5,8}, {3,6,9} };
            int[,] matrixReal = new int[3, 3];
            matrixReal = Program.FunctionA(3, matrixReal);

            CollectionAssert.AreEqual(matrixTest, matrixReal);

        }

        [TestMethod]
        public void TestEs10FunctionB()
        {
            int[,] matrixTest = { {1,6,7}, {2,5,8}, {3,4,9} };
            int[,] matrixReal = new int[3, 3];
            matrixReal = Program.FunctionB(3, matrixReal);

            CollectionAssert.AreEqual(matrixTest, matrixReal);
        }

        [TestMethod]
        public void TestEs10FunctionC()
        {
            int[,] matrixTest = { {4,7,9}, {2,5,8}, {1,3,6} };
            int[,] matrixReal = new int[3, 3];
            matrixReal = Program.FunctionC(3, matrixReal);

            CollectionAssert.AreEqual(matrixTest, matrixReal);
        }


        [TestMethod]
        public void TestEs10FunctionD()
        {
            int[,] matrixTest = { {1,8,7}, {2,9,6}, {3,4,5} };
            int[,] matrixReal = new int[3, 3];
            matrixReal = Program.FunctionD(3, matrixReal);

            CollectionAssert.AreEqual(matrixTest, matrixReal);
        }
    }
}
