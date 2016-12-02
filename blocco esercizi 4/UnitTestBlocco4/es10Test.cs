using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_10;

namespace UnitTestBlocco4
{
    [TestClass]

    public class TestEmployee
    {
        [TestMethod]
        public void TestSalary()
        {
            Employee[] employees = new Employee[]
            {
                new SalaryWorker("pippo", 30000),
                new SalaryWorker("pluto", 24000)
            };

            Assert.AreEqual(2500, employees[0].calcPaidCheck());
            Assert.AreEqual(2000, employees[1].calcPaidCheck());
        }

        [TestMethod]
        public void TestHourly()
        {
            Employee[] employees = new Employee[]
            {
                new HourlyWorker("pippo", 10 , 100),
                new HourlyWorker("pluto", 15 , 100)
            };

            Assert.AreEqual(1000, employees[0].calcPaidCheck());
            Assert.AreEqual(1500, employees[1].calcPaidCheck());
        }
    }
}