using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab11;
using System;

namespace MyPriorityQueueTests
{
    [TestClass]
    public class MyPriorityQueueTests
    {
        [TestMethod]
        public void Add_ShouldIncreaseSize()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);

            Assert.AreEqual(2, queue.Size());
        }

        [TestMethod]
        public void Peek_ShouldReturnMinElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);
            queue.Add(7);

            Assert.AreEqual(3, queue.Peek());
        }

        [TestMethod]
        public void Poll_ShouldReturnAndRemoveMinElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);
            queue.Add(7);

            int min = queue.Poll();

            Assert.AreEqual(3, min);
            Assert.AreEqual(2, queue.Size());
        }

        [TestMethod]
        public void Contains_ShouldReturnTrueForExistingElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);
            queue.Add(7);

            Assert.IsTrue(queue.Contains(3));
        }

        [TestMethod]
        public void Contains_ShouldReturnFalseForNonExistingElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);

            Assert.IsFalse(queue.Contains(7));
        }

        [TestMethod]
        public void Remove_ShouldRemoveSpecifiedElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);
            queue.Add(7);

            bool result = queue.Remove(3);

            Assert.IsTrue(result);
            Assert.AreEqual(2, queue.Size());
            Assert.IsFalse(queue.Contains(3));
        }

        [TestMethod]
        public void Remove_ShouldReturnFalseForNonExistingElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);

            bool result = queue.Remove(7);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Clear_ShouldEmptyTheQueue()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);
            queue.Add(7);

            queue.Clear();

            Assert.AreEqual(0, queue.Size());
            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void AddAll_ShouldAddAllElementsFromArray()
        {
            var queue = new MyPriorityQueue<int>();
            queue.AddAll(new int[] { 5, 3, 7 });

            Assert.AreEqual(3, queue.Size());
            Assert.AreEqual(3, queue.Peek());
        }

        [TestMethod]
        public void RetainAll_ShouldRetainOnlySpecifiedElements()
        {
            var queue = new MyPriorityQueue<int>();
            queue.AddAll(new int[] { 5, 3, 7, 9 });

            queue.RetainAll(new int[] { 3, 7 });

            Assert.AreEqual(2, queue.Size());
            Assert.IsTrue(queue.Contains(3));
            Assert.IsTrue(queue.Contains(7));
            Assert.IsFalse(queue.Contains(5));
            Assert.IsFalse(queue.Contains(9));
        }

        [TestMethod]
        public void ToArray_ShouldReturnAllElements()
        {
            var queue = new MyPriorityQueue<int>();
            queue.AddAll(new int[] { 5, 3, 7 });

            var result = queue.ToArray();

            CollectionAssert.AreEquivalent(new int[] { 5, 3, 7 }, result);
        }

        [TestMethod]
        public void Offer_ShouldReturnTrueOnSuccess()
        {
            var queue = new MyPriorityQueue<int>();

            bool result = queue.Offer(5);

            Assert.IsTrue(result);
            Assert.AreEqual(1, queue.Size());
            Assert.AreEqual(5, queue.Peek());
        }

        [TestMethod]
        public void Element_ShouldReturnMinElement()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);
            queue.Add(3);
            queue.Add(7);

            Assert.AreEqual(3, queue.Element());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Element_ShouldThrowExceptionWhenQueueIsEmpty()
        {
            var queue = new MyPriorityQueue<int>();

            queue.Element();
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnTrueForEmptyQueue()
        {
            var queue = new MyPriorityQueue<int>();

            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void IsEmpty_ShouldReturnFalseForNonEmptyQueue()
        {
            var queue = new MyPriorityQueue<int>();
            queue.Add(5);

            Assert.IsFalse(queue.IsEmpty());
        }
    }
}