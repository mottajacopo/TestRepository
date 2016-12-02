using System;
using System.Text;
using System.Collections.Generic;
using es_07;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Net;

namespace UnitTestBlocco3
{
  
    [TestClass]
    public class es07Test
    {
        [TestMethod]
        public void TestDownloadFile()
        {
            string url = @"http://imgur.com/a/yjzwP";
            string filename = "prova.jpg";

            Program.Download(url, filename);
            Assert.IsTrue(File.Exists("prova.jpg"));
        }

        [TestMethod]
        [ExpectedException(typeof(WebException) )]
        public void TestDownloadFileException()
        {
            string url = "Http";
            string filename = "prova.jpg";
            Program.Download(url, filename);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestDownloadFileWebException()
        {
            string url = @"http://imgur.com/a/yjzwP";
            string filename =null;

            Program.Download(url, filename);
        }
    }
}
