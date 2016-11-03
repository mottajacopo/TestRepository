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

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayTest1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arrayTest2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Program.Randomizer(10 , ref arrayTest1);

            CollectionAssert.AreNotEqual(array , arrayTest1);

            Program.Randomizer(10, ref arrayTest2);

            CollectionAssert.AreNotEqual(array, arrayTest2);
            CollectionAssert.AreNotEqual(arrayTest1, arrayTest2);

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
            Assert.AreEqual( 10, counter);
        }
    }
}

