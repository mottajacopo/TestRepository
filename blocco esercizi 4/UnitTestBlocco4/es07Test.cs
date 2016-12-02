using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_07;

namespace UnitTestBlocco4
{
    [TestClass]
    public class Person
    {
        [TestMethod]
        public void TestSunSign()
        {
            Person paoloRossi = new Person("Paolo", "Rossi");
        }
    }
}
