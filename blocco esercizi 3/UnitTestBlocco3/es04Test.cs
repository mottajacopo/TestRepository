using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_04;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es04Test
    {
        [TestMethod]
        public void TestWorkdaySimple()
        {
            DateTime dtStart = new DateTime(2016, 11, 13);
            DateTime dtEnd = new DateTime(2016, 11, 28);
            Assert.AreEqual(12, Program.Compute(dtStart, dtEnd));
        }

        [TestMethod]
        public void TestWorkdayComplex()
        {
            DateTime dtStart = new DateTime(2016, 11, 13);
            DateTime dtEnd = new DateTime(2017, 8, 21);
            Assert.AreEqual(195, Program.Compute(dtStart, dtEnd));
        }

        [TestMethod]
        public void TestWorkdayComplex2()
        {
            DateTime dtStart = new DateTime(2016, 11, 13);
            DateTime dtEnd = new DateTime(2019, 4, 25);
            Assert.AreEqual(619, Program.Compute(dtStart, dtEnd));
        }

        [TestMethod]
        public void TestWorkdayChristmasPeriod()
        {
            DateTime dtStart = new DateTime(2016, 12, 22);
            DateTime dtEnd = new DateTime(2016, 12, 29);
            Assert.AreEqual(5, Program.Compute(dtStart, dtEnd));
        }
    }
}
