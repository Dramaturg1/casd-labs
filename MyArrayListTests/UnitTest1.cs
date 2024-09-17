using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using lab4;

namespace MyArrayListTests
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        public void Method()
        {
            
        }
        */

        [TestMethod]
        public void ConstructorTests()
        {
            lab4.MyArrayList<int> list1 = new lab4.MyArrayList<int>();
            lab4.MyArrayList<int> list2 = new lab4.MyArrayList<int>(10);
            int[] array = { 1, 2, 3, 4, 5};
            lab4.MyArrayList<int> list3 = new lab4.MyArrayList<int>(array);
        }

        [TestMethod]
        public void AddGetMethod()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5, 6 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            list.Add(6);
            array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.Get(i);
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void AddAllArrTest()
        {
            int[] array = { 1, 2, 3, 4 };
            int[] addArray = { 5, 6, 7 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            list.AddAll(addArray);
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            array = new int[7];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.Get(i);
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void ClearGetSizeTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            list.Clear();
            int size = list.GetSize();
            CollectionAssert.Equals(size, 0);
        }

        [TestMethod]
        public void ContainsAllTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int[] subArray = { 1, 3, 5 };
            CollectionAssert.Equals(list.ContainsAll(subArray), true);
            subArray[2] = 8;
            CollectionAssert.Equals(list.ContainsAll(subArray), false);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>();
            CollectionAssert.Equals(list.IsEmpty(), true);
            list.Add(1);
            CollectionAssert.Equals(list.IsEmpty(), false);
        }

        [TestMethod]
        public void RemoveAllTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int[] toRemove = { 1, 2, 5 };
            list.RemoveAll(toRemove);
            array = new int[4];
            for (int i = 0; i <  array.Length; i++)
            {
                array[i] = list.Get(i);
            }
            int[] expected = { 3, 4, 6, 7 };
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RetainAllTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int[] toRetain = { 1, 2, 5 };
            list.RetainAll(toRetain);
            array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.Get(i);
            }
            CollectionAssert.AreEqual(toRetain, array);
        }

        [TestMethod]
        public void GetSizeTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            CollectionAssert.Equals(list.GetSize(), 7);
        }

        [TestMethod]
        public void AddIndTest()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            list.Add(3, 10);
            int[] expected = { 1, 2, 3, 10, 4, 5, 6, 7 };
            array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.Get(i);
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]
        public void AddAllIndTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int[] toInsert = { 9, 9, 9 };
            int[] expected = { 1, 2, 3, 9, 9, 9, 4, 5 };
            list.AddAll(3, toInsert);
            array = new int[8];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list.Get(i);
            }
            CollectionAssert.AreEqual(array, expected);
        }


        [TestMethod]
        public void toArrayTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            
            CollectionAssert.AreEqual(array, list.ToArray());
        }

        [TestMethod]
        public void IndexOfTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int index = list.IndexOf(3);
            Assert.AreEqual(2, index);
        }

        [TestMethod]
        public void IndexOfNotFoundTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int index = list.IndexOf(6);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void LastIndexOfTest()
        {
            int[] array = { 1, 2, 3, 2, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int index = list.LastIndexOf(2);
            Assert.AreEqual(3, index);
        }

        [TestMethod]
        public void LastIndexOfNotFoundTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            int index = list.LastIndexOf(6);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void RemoveTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            list.Remove(2);
            int[] expected = { 1, 2, 4, 5 };
            int[] actual = list.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            list.Set(2, 10);
            int[] expected = { 1, 2, 10, 4, 5 };
            int[] actual = list.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubListTest()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            var subList = list.SubList(1, 3);
            int[] expected = { 2, 3, 4 };
            int[] actual = subList.ToArray();
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
