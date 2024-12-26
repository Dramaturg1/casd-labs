using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab14;
using System;

namespace MyArrayDequeTests
{
    [TestClass]
    public class MyArrayDequeTests
    {
        [TestMethod]
        public void Add_ShouldIncreaseSize()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            Assert.AreEqual(2, deque.Size());
        }

        [TestMethod]
        public void Poll_ShouldReturnAndRemoveFirstElement()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            int result = deque.Poll();

            Assert.AreEqual(5, result);
            Assert.AreEqual(1, deque.Size());
        }

        [TestMethod]
        public void Peek_ShouldReturnFirstElementWithoutRemoving()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            int result = deque.Peek();

            Assert.AreEqual(5, result);
            Assert.AreEqual(2, deque.Size());
        }

        [TestMethod]
        public void AddFirst_ShouldAddElementAtTheFront()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.AddFirst(3);

            Assert.AreEqual(3, deque.PeekFirst());
            Assert.AreEqual(5, deque.PeekLast());
        }

        [TestMethod]
        public void AddLast_ShouldAddElementAtTheEnd()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.AddLast(7);

            Assert.AreEqual(5, deque.PeekFirst());
            Assert.AreEqual(7, deque.PeekLast());
        }

        [TestMethod]
        public void RemoveFirst_ShouldRemoveAndReturnFirstElement()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            int result = deque.RemoveFirst();

            Assert.AreEqual(5, result);
            Assert.AreEqual(1, deque.Size());
        }

        [TestMethod]
        //???????????????? причина
        //
        //
        public void RemoveLast_ShouldRemoveAndReturnLastElement()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            int result = deque.RemoveLast();

            Assert.AreEqual(3, result);
            Assert.AreEqual(1, deque.Size());
        }

        [TestMethod]
        public void Remove_ShouldRemoveSpecifiedElement()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);
            deque.Add(7);

            bool result = deque.Remove(3);

            Assert.IsTrue(result);
            Assert.AreEqual(2, deque.Size());
            Assert.IsFalse(deque.Contains(3));
        }

        [TestMethod]
        public void RemoveFirstOccurrence_ShouldRemoveFirstMatchingElement()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);
            deque.Add(5);

            bool result = deque.RemoveFirstOccurrence(5);

            Assert.IsTrue(result);
            Assert.AreEqual(2, deque.Size());
            Assert.AreEqual(3, deque.PeekFirst());
        }

        [TestMethod]
        public void RemoveLastOccurrence_ShouldRemoveLastMatchingElement()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);
            deque.Add(5);

            bool result = deque.RemoveLastOccurrence(5);

            Assert.IsTrue(result);
            Assert.AreEqual(2, deque.Size());
            Assert.AreEqual(5, deque.PeekFirst());
            Assert.AreEqual(3, deque.PeekLast());
        }

        [TestMethod]
        public void Contains_ShouldReturnTrueIfElementExists()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            Assert.IsTrue(deque.Contains(5));
            Assert.IsFalse(deque.Contains(7));
        }
        [TestMethod]
        public void Clear_ShouldEmptyTheDeque()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            deque.Clear();

            Assert.AreEqual(0, deque.Size());
            Assert.IsTrue(deque.IsEmpty());
        }

        [TestMethod]
        public void ToArray_ShouldReturnAllElementsInOrder()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);
            deque.Add(7);

            var array = deque.ToArray();

            CollectionAssert.AreEqual(new int[] { 5, 3, 7 }, array);
        }

        [TestMethod]
        public void ToArray_WithProvidedArray_ShouldCopyElements()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);
            deque.Add(3);

            int[] array = new int[5];
            deque.ToArray(array);

            CollectionAssert.AreEqual(new int[] { 5, 3, 0, 0, 0 }, array);
        }

        [TestMethod]
        public void Offer_ShouldReturnTrueWhenAddingElement()
        {
            var deque = new MyArrayDeque<int>();

            bool result = deque.Offer(5);

            Assert.IsTrue(result);
            Assert.AreEqual(1, deque.Size());
            Assert.AreEqual(5, deque.Peek());
        }

        [TestMethod]
        public void OfferFirst_ShouldAddElementToTheFront()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);

            bool result = deque.OfferFirst(3);

            Assert.IsTrue(result);
            Assert.AreEqual(2, deque.Size());
            Assert.AreEqual(3, deque.PeekFirst());
        }

        [TestMethod]
        public void OfferLast_ShouldAddElementToTheEnd()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);

            bool result = deque.OfferLast(7);

            Assert.IsTrue(result);
            Assert.AreEqual(2, deque.Size());
            Assert.AreEqual(7, deque.PeekLast());
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnTrueForEmptyDeque()
        {
            var deque = new MyArrayDeque<int>();

            Assert.IsTrue(deque.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnFalseForNonEmptyDeque()
        {
            var deque = new MyArrayDeque<int>();
            deque.Add(5);

            Assert.IsFalse(deque.IsEmpty());
        }
    }
}