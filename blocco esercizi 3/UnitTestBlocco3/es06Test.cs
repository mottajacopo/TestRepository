using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
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
            int[] array = { 1, 2, 3, 4, 5 };
            int[] numbers = Program.ParseNumberFile(@"..\..\file2.txt"); 
            CollectionAssert.AreEqual(array, numbers);

        }
        [TestMethod]
        [ExpectedException(typeof(Program.FileParseException))]
        public void TestFileParse2()
        {
            int[] numbers = Program.ParseNumberFile(@"..\..\file.txt");
        }
    }
}