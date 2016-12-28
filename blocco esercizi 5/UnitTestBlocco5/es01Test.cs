using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_01;

namespace UnitTestBlocco5
{
    [TestClass]
    public class es01Test
    {
            [TestMethod]
        public void TestEs01TList()
        {
            ITaxable[] tObjects = new ITaxable[]
            {
                new HouseTax("Gotham", true, 300, 800000),
                new HouseTax("Spingfield", false, 200, 150000),
                new HouseTax("Metropolis", true, 200, 1000000),
                new BusTax(10, 712355, 15000),
                new BusTax(30, 367634, 30000),
                new BusTax(55, 655120, 45000) };
        }

        [TestMethod]
        public void TestEs01HouseTax()
        {
            HouseTax test1 = new HouseTax("Gotham", true, 200, 800000);
            HouseTax test2 = new HouseTax("Spingfield", false, 200, 150000);
            Assert.AreEqual(4800, test1.Taxable());
            Assert.AreEqual(750, test2.Taxable());
        }

        [TestMethod]
        public void TestEs01BusTax()
        {
            BusTax test1 = new BusTax(10, 712355, 15000);
            BusTax test2 = new BusTax(20, 367634, 30000);
            Assert.AreEqual(300, test1.Taxable());
            Assert.AreEqual(300, test2.Taxable());
        }
    }
}
