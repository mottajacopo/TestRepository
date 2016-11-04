using System;
using es_09;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class es09Test
    {
        [TestMethod]
        public void TestEs09MaxSequence()
        {
            int[] array = { 6, 9, 2, 7, 4, 7, 6, 5, 8, 4 };
            int[] test = { 2, 4, 5, 8, 0, 0, 0, 0, 0, 0 };
            int[] seq = new int[10];       //array che conterrà la sequenza
            Program.MaxSequence(array, 10, ref seq);

            CollectionAssert.AreEqual(test, seq);

        }

        [TestMethod]
        public void TestEs09MaxSequence2()
        {
            int[] array = { 13, 10, 7, 1, 9, 15, 18, 6, 12, 30 };
            int[] test = { 1, 9, 15, 18, 30, 0, 0, 0, 0, 0 };
            int[] seq = new int[10];       //array che conterrà la sequenza
            Program.MaxSequence(array, 10, ref seq);

            CollectionAssert.AreEqual(test, seq);
        }

        [TestMethod]
        public void TestEs09MaxSequenceEqualNumbers()
        {
            int[] array = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            int[] test = { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] seq = new int[10];       //array che conterrà la sequenza
            Program.MaxSequence(array, 10, ref seq);

            CollectionAssert.AreEqual(test, seq);

        }
    }
}
