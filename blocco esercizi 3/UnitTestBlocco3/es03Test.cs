using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using es_03;

namespace UnitTestBlocco3
{
   
    [TestClass]
    public class es03Test
    {
        [TestMethod]
        public void TestDirSearchCount()
        {
            string sDir = @"..\..\cartella_test_03";
            List<string> filesAndFolders = Program.DirSearch(sDir);
            Assert.AreEqual(8, filesAndFolders.Count);
        }
    }
}
