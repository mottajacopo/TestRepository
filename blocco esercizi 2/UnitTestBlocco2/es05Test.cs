﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_05;

namespace UnitTestBlocco2
{
    [TestClass]
    public class Es05Test
    {
        [TestMethod]
        public void TestEs05Factor()
        {
            double factor;
            factor = Program.factorial(5);
            Assert.AreEqual( 120, factor);
            factor = Program.factorial(12);
            Assert.AreEqual(479001600, factor);
        }
        [TestMethod]
        public void TestEs05Exp()
        {
            double exp;
            exp = Program.exponential(2, 5);
            Assert.AreEqual(32 , exp);
            exp = Program.exponential(-7, 5);
            Assert.AreEqual(-16807, exp);

        }
        [TestMethod]
        public void TestEs05Sum()
        {
            double sum;
            sum = Program.calculate(1, 3);
            Assert.AreEqual(sum, 10 ,sum);
            sum = Program.calculate(-4, 5);
            Assert.AreEqual( 0.7578125 , sum);

        }
    }   
}
