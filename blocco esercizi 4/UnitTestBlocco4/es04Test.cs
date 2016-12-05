using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_04;

namespace UnitTestBlocco4
{
    [TestClass]
    public class UnitTest04
    {
        static int[] Array;
        static int length;

        [TestMethod]
        public void ReturnToArrayTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            Array = new int[] {1,2,3};
            length = Array.Length;

            int[] array = list.ReturnToArray();
            CollectionAssert.AreEqual(Array, array);
        }

        [TestMethod]
        public void InsertElementTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.InsertElement(1, 0).InsertElement(2, 1).InsertElement(3, 2);

            Assert.AreEqual(3, list.Count);
            int[] expected = { 1,2,3 };
            int[] array = list.ReturnToArray();

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void AddElementToStartTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            list.AddElementToStart(0);
            int[] expected = new int[] { 0, 1, 2, 3 };
            CollectionAssert.AreEqual(expected, list.ReturnToArray());
        }

        [TestMethod]
        public void AddElementToLastTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            list.AddElementToLast(4);
            int[] expected = new int[] { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expected, list.ReturnToArray());
        }

        [TestMethod]
        public void FindElementTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            Array = new int[] { 1, 2, 3 };
            length = Array.Length;

            DoubleLinkedListNode<int> node = list.FindElement(1);
            Assert.AreEqual(list.First, node);
        }

        [TestMethod]
        public void FindTestNotFound()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            Array = new int[] { 1, 2, 3 };
            length = Array.Length;

            DoubleLinkedListNode<int> node = list.FindElement(4);
            Assert.AreEqual(null, node);
        }

        [TestMethod]
        public void RemoveElementTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            list.RemoveElement(2);

            int[] expected = new int[] { 1, 3 };
            CollectionAssert.AreEqual(expected, list.ReturnToArray());
            Assert.AreEqual(1, list.First.Value);
            Assert.AreEqual(3, list.Last.Value);
        }

        [TestMethod]
        public void RemoveFirstTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            list.RemoveElement(1);

            int[] expected = new int[] { 2, 3 };
            CollectionAssert.AreEqual(expected, list.ReturnToArray());
            Assert.AreEqual(2, list.First.Value);
        }

        [TestMethod]
        public void RemoveLastTest()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>(1, 2, 3);
            list.RemoveElement(3);

            int[] expected = new int[] { 1, 2 };
            CollectionAssert.AreEqual(expected, list.ReturnToArray());
            Assert.AreEqual(2, list.Last.Value);
        }
    }
}