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
            decimal result;
            result = Program.fibonacci(3, 5);
            Assert.AreEqual(result, 8);
        }
    }
}
