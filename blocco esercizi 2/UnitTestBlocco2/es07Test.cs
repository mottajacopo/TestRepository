using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_07;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es07Test
    {
        [TestMethod]

        public void TestEs07Randomizer()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = i + 1;
            }

            Program.randomizer(10 , ref array);

            for (int i = 0; i < 10; i++)
            {
                Assert.AreNotEqual(array[i] , i+1);
            }
        }

    }
}