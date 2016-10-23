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
            int[] test = {2, 4, 5, 8, 0, 0, 0, 0, 0, 0 };
            int[] seq = new int[10];       //array che conterrà la sequenza
            Program.maxSequence(array, 10 , ref seq);

            for(int i=  0; i < 10; i++)
            {
                Assert.AreEqual( test[i] , seq[i]);
            } 
        }
    }
}
