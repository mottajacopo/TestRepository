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

        private bool Contain(string str, string[] array)
        {
            bool flag = false;
            foreach (string s in Program.PhraseFinal)
            {
                flag = str.Contains(s);
                if (flag == true)
                    break;
            }

            return flag;
        }

        [TestMethod]
        public void IsComplete()
        {
            string sentence = Program.RandomAdvertisement();

            Assert.IsTrue(Contain(sentence, Program.Phrase1));
            Assert.IsTrue(Contain(sentence, Program.Phrase2));
            Assert.IsTrue(Contain(sentence, Program.Phrase3));
            Assert.IsTrue(Contain(sentence, Program.Phrase4));
            Assert.IsTrue(Contain(sentence, Program.Phrase5));
        }

    }
}
