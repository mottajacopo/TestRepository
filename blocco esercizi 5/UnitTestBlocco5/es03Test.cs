using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_03;

namespace UnitTestBlocco5
{
    [TestClass]
    public class es03Test
    {
        [TestMethod]
        public void TestEs03TwoSixes()
        {
            Die testDice = new Die();
            bool twoSixesEvent = false;
            for (int i = 1; i < 10000; i++)
            {
                testDice.Toss();
                testDice.twoSixesInARow += delegate () { twoSixesEvent = true; };
            }
            Assert.IsTrue(twoSixesEvent);
        }
    }
}
