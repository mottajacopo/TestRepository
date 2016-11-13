using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_06;

namespace UnitTestBlocco3
{
    [TestClass]
    public class Es06Test
    {
        [TestMethod]
        public void TestFileParse()
        {
            string getInput = @"..\..\correctTest.txt";
            FileParses.FileParse(getInput);

        }
        [TestMethod]
        [ExpectedException(typeof(FileParseException))]
        public void TestFileParseWrong()
        {
            string getInput = @"..\..\wrongTest.txt";
            FileParses.FileParse(getInput);
        } 
    }
}