using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StackUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PushTest()
        {
            lab8.MyStack<int> stack = new lab8.MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int[] arr = new int[5];
            arr = stack.ToArray();
            int[] expected = { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void PopTest()
        {
            lab8.MyStack<int> stack = new lab8.MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            int[] arr = new int[4];
            arr = stack.ToArray();
            int[] expected = { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expected, arr);
        }

        [TestMethod]
        public void PeekTest()
        {
            lab8.MyStack<int> stack = new lab8.MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int expected = 5;
            Assert.AreEqual(expected, stack.Peek());
        }

        [TestMethod]
        public void EmptyTest()
        {
            lab8.MyStack<int> stack = new lab8.MyStack<int> ();
            Assert.AreEqual(stack.Empty(), true);
            stack.Push(1);
            Assert.AreEqual(stack.Empty(), false);
        }

        [TestMethod]
        public void SearchTest()
        {
            lab8.MyStack<int> stack = new lab8.MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            int expected = 4;
            Assert.AreEqual(expected, stack.Search(2));
            Assert.AreEqual(-1, stack.Search(10));
        }
    }
}
