using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab16;

namespace MyLinkedListTests
{
    [TestClass]
    public class MyLinkedListTests
    {
        private MyLinkedList<int> list;

        [TestInitialize]
        public void SetUp()
        {
            list = new MyLinkedList<int>();
        }

        [TestMethod]
        public void TestAddLast()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Assert.AreEqual(3, list.Size());
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, list.ToArray());
        }

        [TestMethod]
        public void TestAddFirst()
        {
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            Assert.AreEqual(3, list.Size());
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, list.ToArray());
        }

        [TestMethod]
        public void TestAddAtIndex()
        {
            list.AddLast(1);
            list.AddLast(3);
            list.Add(1, 2);

            Assert.AreEqual(3, list.Size());
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, list.ToArray());
        }

        [TestMethod]
        public void TestRemove()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            list.Remove(1);

            Assert.AreEqual(2, list.Size());
            CollectionAssert.AreEqual(new int[] { 1, 3 }, list.ToArray());
        }

        [TestMethod]
        public void TestContains()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Assert.IsTrue(list.Contains(2));
            Assert.IsFalse(list.Contains(4));
        }

        [TestMethod]
        public void TestIndexOf()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            Assert.AreEqual(1, list.IndexOf(2));
            Assert.AreEqual(-1, list.IndexOf(4));
        }

        [TestMethod]
        public void TestClear()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            list.Clear();

            Assert.AreEqual(0, list.Size());
            Assert.IsTrue(list.IsEmpty());
        }

        [TestMethod]
        public void TestSubList()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            var sublist = list.SubList(1, 4);

            CollectionAssert.AreEqual(new int[] { 2, 3, 4 }, sublist);
        }

        [TestMethod]
        public void TestRemoveFirstOccurrence()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(2);

            Assert.IsTrue(list.RemoveFirstOccurrence(2));
            CollectionAssert.AreEqual(new int[] { 1, 3, 2 }, list.ToArray());
        }

        [TestMethod]
        public void TestRemoveLastOccurrence()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(2);

            Assert.IsTrue(list.RemoveLastOccurrence(2));
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, list.ToArray());
        }

        [TestMethod]
        public void TestToArray()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            var array = list.ToArray();

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, array);
        }

        [TestMethod]
        public void TestRemoveAll()
        {
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            list.RemoveAll(2, 4);

            CollectionAssert.AreEqual(new int[] { 1, 3 }, list.ToArray());
        }
    }
}