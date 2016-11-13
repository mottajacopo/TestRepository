using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_02;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es02Test
    {
        [TestMethod]
        public void TestSumSimple()
        {
            string num1 = "2459872";
            string num2 = "190";
            string result = Program.Sum(num1, num2);
            Assert.AreEqual("2460062", result);
        }

        [TestMethod]
        public void TestSumSimple2()
        {
            string num1 = "9";
            string num2 = "101";
            string result = Program.Sum(num1, num2);
            Assert.AreEqual("110", result);
        }
        [TestMethod]
        public void TestSumComplex()
        {
            string num1 = "294827482019257385294827482019257385294827482019257385294827482019257385294827482019257385";
            string num2 = "12";
            string result = Program.Sum(num1, num2);
            Assert.AreEqual("294827482019257385294827482019257385294827482019257385294827482019257385294827482019257397", result);
        }
        [TestMethod]
        public void TestSumCarry()
        {
            string num1 = "999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999";
            string num2 = "1";
            string result = "1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
            Assert.AreEqual(result, Program.Sum(num1, num2));
        }
    }
}