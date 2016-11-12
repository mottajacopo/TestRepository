using System;
using es_05;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBlocco3
{
    [TestClass]
    public class es05Test
    {
        [TestMethod]
        public void TestRandomAdvertisement()
        {
            string PhraseTest1 = Program.RandomAdvertisement();
            string PhraseTest2 = Program.RandomAdvertisement();
            string PhraseTest3 = Program.RandomAdvertisement();

            Assert.AreNotSame(PhraseTest1, PhraseTest2, PhraseTest3);
        }

    }
}
