using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_06;

namespace UnitTestBlocco4
{
    [TestClass]
    public class TestStructTime
    {
        [TestMethod]
        public void TestMinuteOfDay()
        {
            Time t1 = new Time(10, 28);
            Assert.AreEqual(28, t1.Minute);

            Time t2 = new Time(7, 35);
            Assert.AreEqual(35, t2.Minute);
        }
        [TestMethod]
        public void TestHourOfDay()
        {
            Time t1 = new Time(10, 28);
            Assert.AreEqual(10, t1.Hour);

            Time t2 = new Time(7, 35);
            Assert.AreEqual(7, t2.Hour);
        }
        [TestMethod]
        public void TestTimeStringFormat()
        {
            Time t1 = new Time(10, 28);
            Assert.AreEqual("10:28", t1.ToString());

            Time t2 = new Time(7, 35);
            Assert.AreEqual("07:35", t2.ToString());
        }
        [TestMethod]
        public void AddTwoTimes()
        {
            Time t1 = new Time(10, 28);
            Time t2 = new Time(7, 35);
            Assert.AreEqual(18, (t1 + t2).Hour);
            Assert.AreEqual(3, (t1 + t2).Minute);
            Assert.AreEqual("18:03", (t1+t2).ToString());
        }
        [TestMethod]
        public void SubTwoTimes()
        {
            Time t1 = new Time(10, 28);
            Time t2 = new Time(7, 35);
            Assert.AreEqual(2, (t1 - t2).Hour);
            Assert.AreEqual(53, (t1 - t2).Minute);
            Assert.AreEqual("02:53", (t1 - t2).ToString());
        }
        [TestMethod]
        public void TestTimeImplicitConversion()
        {
            Time t1 = new Time(10, 28);
            Assert.AreEqual(628, t1);
            
            Time t2 = new Time(7, 35);
            Assert.AreEqual(455, t2);
           
        }
        [TestMethod]
        public void TestTimeExplicitConversion()
        {
            int totalMinutes1 = 628;
            Time t1 = new Time(totalMinutes1 / 60, totalMinutes1 % 60);
            Assert.AreEqual(628, t1);

            int totalMinutes2 = 455;
            Time t2 = new Time(totalMinutes2 / 60, totalMinutes2 % 60);
            Assert.AreEqual(455, t2);

        }
    }
}
