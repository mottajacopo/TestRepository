using System;
using System.IO;
using System.Text;
using es_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco4
{
    [TestClass]
    public class TestParser
    {
        [TestMethod]
        public void XmlParser()
        {
            Parser test = new Parser();
            string actualResult = test.Xml("..\\..\\XML.xml"); 
            string expectedResult = "Peter\n21\nGames\nC#\nJava\n";
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
