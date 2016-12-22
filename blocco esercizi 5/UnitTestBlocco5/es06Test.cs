using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_06;

namespace UnitTestBlocco5
{
    [TestClass]
    public class TestEs06Interval
    {
        [TestMethod]
        public void TestEs06IntervalProperties()
        {
            Interval range = new Interval(8, 21);
            Assert.AreEqual(8, range.From);
            Assert.AreEqual(21, range.To);
            Assert.AreEqual(14, range.Length);

            for(int k = 8; k <= 21; k++)
            {
                Assert.AreEqual(k, range[k - 8]);
            }         
        }

        [TestMethod]
        public void TestEs06IntervalOperators()
        {
            Interval range = new Interval(8, 21);

            range = range + 5;
            Assert.AreEqual(13, range.From);
            Assert.AreEqual(26, range.To);

            range = range >> 3;
            Assert.AreEqual(29, range.To);
            Assert.AreEqual(17, range.Length);

            range = range << 4;
            Assert.AreEqual(17, range.From);
            Assert.AreEqual(13, range.Length);

            range = range - 10;
            Assert.AreEqual(7, range.From);
            Assert.AreEqual(19, range.To);

            range = range * 2;
            Assert.AreEqual(14, range.From);
            Assert.AreEqual(38, range.To);
            Assert.AreEqual(25, range.Length);

            range = !range;
            Assert.AreEqual(38, range.From);
            Assert.AreEqual(14, range.To);
        }
    }
}
