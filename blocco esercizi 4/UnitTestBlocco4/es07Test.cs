using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_07;

namespace UnitTestBlocco4
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestIsAdult()
        {
            Person pr = new Person("Paolo", "Rossi", new DateTime(1986, 6, 11));
            Assert.IsTrue(pr.Adult);

            Person fb = new Person("Francesco", "Bianchi", new DateTime(2001, 11, 22));
            Assert.IsFalse(fb.Adult);
        }

        [TestMethod]
        public void TestSunSign()
        {
            Person pr = new Person("Paolo", "Rossi", new DateTime(1986, 6, 11));
            Assert.AreEqual("Gemelli", pr.SunSign);

            Person fb = new Person("Francesco", "Bianchi", new DateTime(2001, 11, 22));
            Assert.AreEqual("Scorpione", fb.SunSign);
        }
        [TestMethod]
        public void TestChineseSign()
        {
            Person pr = new Person("Paolo", "Rossi", new DateTime(1986, 6, 11));
            Assert.AreEqual("Tigre", pr.ChineseSign);

            Person fb = new Person("Francesco", "Bianchi", new DateTime(2001, 11, 22));
            Assert.AreEqual("Serpente", fb.ChineseSign);
        }
        [TestMethod]
        public void TestBirthdayTrue()
        {
            Person pr = new Person("Paolo", "Rossi", DateTime.Today);
            Assert.IsTrue(pr.Birthday);
        }
        [TestMethod]
        public void TestBirthdayFalse()
        {
            Person pr = new Person("Paolo", "Rossi", new DateTime(1986, DateTime.Today.Month, DateTime.Today.Day + 1));
            Assert.IsFalse(pr.Birthday);
        }
        [TestMethod]
        public void TestScreenName()
        {
            Person pr = new Person("Paolo", "Rossi", new DateTime(1986, 6, 11));
            Assert.AreEqual("paolorossi1986", pr.ScreenName);

            Person fb = new Person("Francesco", "Bianchi", new DateTime(2001, 11, 22));
            Assert.AreEqual("francescobianchi2001", fb.ScreenName);
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestFutureBirthConstructor()
        {
            Person jd = new Person("John", "Doe", "johndoe@gmail.com", new DateTime(2030, 4, 13));
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestFutureBirthSet()
        {
            Person nb = new Person("Napoleone", "Bonaparte", "napo@gmail.com");
            nb.DateOfBirth = (new DateTime(1769, 8, 15));
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestOldBirthDateConstructor()
        {
            Person nb = new Person("Napoleone", "Bonaparte", "napo@gmail.com", new DateTime(1769, 8, 15));
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestOldBirthDateSet()
        {
            Person nb = new Person("Napoleone", "Bonaparte", "napo@gmail.com");
            nb.DateOfBirth = (new DateTime(1769, 8, 15));
        }
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void TestSetEmailWrong()
        {
            Person pr = new Person("Paolo", "Rossi", new DateTime(1986, 6, 11));
            pr.EmailAddress = "paolorossi.it";
        }
    }
}
