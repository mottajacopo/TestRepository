using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_01;

namespace UnitTestBlocco4
{
    [TestClass]
    public class TestGSM
    {

        [TestMethod]
        public void GSMAddCall()
        {
            GSM samsungGalaxyS7 = new GSM("Samsung Galaxy S7", "Samsung", "Pippo", 800, new Battery("3000mAh", 100, 22), new Display(5.2f, 16000000));
            samsungGalaxyS7.AddCall("12-11-2016", "11:30" , 10);
            samsungGalaxyS7.AddCall("28-10-2016", "14:37", 15);
            samsungGalaxyS7.AddCall("16-10-2016", "18:05", 5);
            samsungGalaxyS7.AddCall("10-10-2016", "21:45", 4);

            Assert.AreEqual(4 , samsungGalaxyS7.counter);
        }

    }
}
