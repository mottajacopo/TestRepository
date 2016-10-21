using System;
using es_02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es02Test
    {
        [TestMethod]
        public void TestEs02Fibonacci()
        {
            decimal[] result = Program.fibonacci();
   
            for (int i = 2; i < 100; i++)
                Assert.AreEqual(result[i - 2] + result[i - 1], result[i]);
        }
    }
}
