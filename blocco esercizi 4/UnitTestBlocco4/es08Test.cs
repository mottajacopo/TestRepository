using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_08;

namespace UnitTestBlocco4
{
    [TestClass] 
    public class TestEmployee
    {
        [TestMethod]
        public void TestRetrieveAmount()
        {
            Employee  pr = new Employee("Paolo", "Rossi", new DateTime(1986, 6, 11), 2000, "paolo.rossi1986@gmail.com");
            Assert.AreEqual(2000, pr.RetrieveAmount());
        }

        [TestMethod]
        public void TestAddToAmount()
        {
            Employee pr = new Employee("Paolo", "Rossi", new DateTime(1986, 6, 11), 2000, "paolo.rossi1986@gmail.com");
            Assert.AreEqual(3500, pr.AddToAmount(1500));
        }
    }
}