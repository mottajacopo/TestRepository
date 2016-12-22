using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_02;

namespace UnitTestBlocco5
{
    [TestClass]
    public class TestEs02Die
    {
        [TestMethod]
        public void TestSortArrayDice()
        {
            Die[] dice = new Die[] { new Die(), new Die(), new Die(), new Die(), new Die(), new Die(), new Die(), new Die(), new Die(), new Die()};

            Array.Sort(dice);

            for (int k = 0; k < 9; k++)
            {

                int valPrev = dice[k].Number();
                int valNext = dice[k + 1].Number();
                Assert.IsTrue(valPrev <= valNext);
            }
        }
    }
}
