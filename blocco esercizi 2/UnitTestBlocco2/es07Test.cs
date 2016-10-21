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

            int counter = 0; //se il contatore è arrivato a 10, l'array contiene tutti gli elementi distinti

            for(int i = 1; i <= 10; i++) //numero
            {
                for(int j = 0; j < 10; j++) //posizione
                {
                    if(array[j] == i)
                    {
                        counter++;
                    }
                }
            }
            Assert.AreEqual(counter, 10);



        }

    }
}