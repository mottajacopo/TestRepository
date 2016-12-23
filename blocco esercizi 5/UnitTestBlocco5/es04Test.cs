using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_04;

namespace UnitTestBlocco5
{
    [TestClass]
    public class TestEs04Complex
    {
        [TestMethod]
        public void TestEs04Sum()
        {
            Complex z1 = new Complex(7, -3);
            Complex z2 = new Complex(11, 7);
            Complex sum = z1 + z2;

            Assert.AreEqual("18 +4i", sum.ToStringForm());
        }
        [TestMethod]
        public void TestEs04Difference()
        {
            Complex z1 = new Complex(7, -3);
            Complex z2 = new Complex(11, 7);
            Complex sum = z1 - z2;

            Assert.AreEqual("-4 -10i", sum.ToStringForm());
        }
        [TestMethod]
        public void TestEs04Multiplication()
        {
            Complex z1 = new Complex(7, -3);
            Complex z2 = new Complex(11, 7);
            Complex sum = z1 * z2;

            Assert.AreEqual("98 +16i", sum.ToStringForm());
        }
        [TestMethod]
        public void TestEs04Division()
        {
            Complex z1 = new Complex(28, 24);
            Complex z2 = new Complex(8, 2);
            Complex sum = z1 / z2;

            Assert.AreEqual("4 +2i", sum.ToStringForm());
        }

        [TestMethod]
        public void TestEs04Conjugate()
        {
            Complex z1 = new Complex(7, -3);
            Complex conjugate = ~z1;
            Assert.AreEqual("7 +3i", conjugate.ToStringForm());
        }
    }

    [TestClass]
    public class TestEs04TriBool
    {
        [TestMethod]
        public void TestEs04Conversions()
        {
            TriBool t1 = new TriBool(-1);
            TriBool t2 = new TriBool(1);

            bool b1 = (bool)t1;
            Assert.IsFalse(b1);
            bool b2 = (bool)t2;
            Assert.IsTrue(b2);

            bool b3 = true;
            TriBool t3 = new TriBool(0);
            t3 = (TriBool)b3;
            Assert.AreEqual("true", t3.ToString());
        }

        [TestMethod]
        public void TestEs04Comparisons()
        {
            TriBool t1 = new TriBool(-1);
            TriBool t2 = new TriBool(0);
            TriBool t3 = new TriBool(1);

            Assert.AreEqual("false", (t2 == t3).ToString());
            Assert.AreEqual("true", (t2 != t3).ToString());      
        }
        [TestMethod]
        public void TestEs04LogicalExpressions()
        {
            TriBool t1 = new TriBool(-1);
            TriBool t2 = new TriBool(0);
            TriBool t3 = new TriBool(1);

            Assert.AreEqual("false", (t1 & t2).ToString());
            Assert.AreEqual("true", (t3 & t3).ToString());

            Assert.AreEqual("indeterminate", (t1 | t2).ToString());
            Assert.AreEqual("true", (t1 | t3).ToString());

        }
        [TestMethod]
        public void TestTriBoolTrueFalseOperator()
        {
            TriBool t1 = false;
            TriBool t2 = true;

            Assert.AreEqual("false", t1.ToString());
            Assert.AreEqual("true", t2.ToString());
        }
    }
}
