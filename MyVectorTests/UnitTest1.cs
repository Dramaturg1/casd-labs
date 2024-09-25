using lab6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyVectorTests
{
    [TestClass]
    public class UnitTest1
    {
        /*
        [TestMethod]
        public void TestMethod1()
        {
        }
        */
        public void ConstructorsTests()
        {
            MyVector<int> v1 = new MyVector<int>();
            MyVector<char> v2 = new MyVector<char>(8, 2);
            MyVector<string> v3 = new MyVector<string>(15);
            double[] arr = { 2.3, 4.6, 2.5, 8.2, 33.9, 34.6, 3.4 };
            MyVector<double> v4 = new MyVector<double>(arr);
            CollectionAssert.AreNotEqual((System.Collections.ICollection)v1, null);
            CollectionAssert.AreNotEqual((System.Collections.ICollection)v2, null);
            CollectionAssert.AreNotEqual((System.Collections.ICollection)v3, null);
            CollectionAssert.AreNotEqual((System.Collections.ICollection)v4, null);
        }

        [TestMethod]
        public void AddTest()
        {
            int[] expected = { 1, 2, 3, 4 };
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            int[] array = new int[v.Size()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]

        public void AddAllTest()
        {
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr = { 1, 2, 3 };
            MyVector<int> v = new MyVector<int>(arr);
            int[] toAdd = { 4, 5, 6, 7 };
            v.AddAll(toAdd);
            int[] array = new int[v.Size()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]

        public void ClearTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Clear();
            v.Add(10);
            int[] expected = new int[v.Size()];
            int[] array = { 10 };
            for (int i = 0; i <  expected.Length; i++)
            {
                expected[i] = v[i];
            }
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]

        public void ContainsFalseTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            CollectionAssert.Equals(v.Contains(0), false);
        }

        public void ContainsTrueTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            CollectionAssert.Equals(v.Contains(1), true);
        }

        [TestMethod]
        
        public void ContainsAllFalseTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            int[] array = { 1, 2, 5 };
            CollectionAssert.Equals(v.Contains(array), false);
        }

        [TestMethod]
        public void ContainsAllTrueTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            int[] array = { 1, 2, 3 };
            CollectionAssert.Equals(v.Contains(array), true);
        }

        [TestMethod]

        public void IsEmptyTrueTest()
        {
            MyVector<int> v = new MyVector<int>();
            CollectionAssert.Equals(v.IsEmpty(), true);
        }

        [TestMethod]

        public void IsEmptyFalseTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            CollectionAssert.Equals(v.IsEmpty(), false);
        }

        [TestMethod]
        
        public void RemoveTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            v.Remove(3);
            int[] expected = { 1, 2, 3 };
            int[] array = new int[v.Size()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]

        public void RemoveAllTest()
        {
            MyVector<int> v = new MyVector<int>();
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            v.AddAll(array);
            int[] toRemove = { 2, 3, 6 };
            v.RemoveAll(toRemove);
            int[] expected = { 1, 4, 5, 7 };
            int[] arr = new int[v.Size()];
            for (int i = 0; i < v.Size(); i++)
            {
                arr[i] = v[i];
            }
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]

        public void RetainAllTest()
        {
            MyVector<int> v = new MyVector<int>();
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            v.AddAll(array);
            int[] toRetain = { 2, 3, 6 };
            v.RetainAll(toRetain);
            int[] expected = { 2, 3, 6 };
            int[] arr = new int[v.Size()]; 
            for (int i = 0; i < v.Size(); i++)
            {
                arr[i] = v[i];
            }
            CollectionAssert.AreEqual(arr, expected);
        }

        [TestMethod]

        public void SizeTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            CollectionAssert.Equals(v.Size(), 2);
        }

        [TestMethod]

        public void ToArrayTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            int[] array = new int[v.Size()];
            array = v.ToArray();
            int[] expected = { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]

        public void AddIndTest()
        {
            int[] expected = { 1, 10, 2, 3, 4 };
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            v.Add(1, 10);
            int[] array = new int[v.Size()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]

        public void AddAllIndTest()
        {
            int[] expected = { 1, 4, 5, 6, 7, 2, 3};
            int[] arr = { 1, 2, 3 };
            MyVector<int> v = new MyVector<int>(arr);
            int[] toAdd = { 4, 5, 6, 7 };
            v.AddAll(1, toAdd);
            int[] array = new int[v.Size()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod] 

        public void GetTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            CollectionAssert.Equals(v.Get(2), 3);
        }

        [TestMethod]

        public void LastIndexOfTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(2);
            v.Add(7);
            v.Add(2);
            v.Add(3);
            CollectionAssert.Equals(v.LastIndexOf(2), 4);
        }

        [TestMethod]

        public void SetTest()
        {
            int[] expected = { 1, 2, 10, 4 };
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            v.Set(2, 10);
            int[] array = new int[v.Size()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(array, expected);
        }

        [TestMethod]

        public void FirstElemTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(2);
            v.Add(7);
            v.Add(2);
            v.Add(3);
            CollectionAssert.Equals(v.FirstElement(), 1);
        }

        [TestMethod]

        public void LastElemTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(2);
            v.Add(7);
            v.Add(2);
            v.Add(3);
            CollectionAssert.Equals(v.LastElement(), 3);
        }

        [TestMethod]

        public void SubListTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            v.Add(5);
            v.Add(6);
            MyVector<int> v2 = v.SubList(2, 5);
            int[] expected = { 3, 4 ,5};
            int[] array = new int[v2.Size()];
            for (int i = 0; i < v2.Size(); i++)
            {
                array[i] = v2[i];
            }
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]

        public void RemoveElemAtTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            v.Add(5);
            v.Add(6);
            v.RemoveElementAt(2);
            int[] expected = { 1, 2, 4, 5, 6 };
            int[] array = new int[v.Size()];
            for (int i = 0; i < v.Size(); i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]

        public void RemoveRangeTest()
        {
            MyVector<int> v = new MyVector<int>();
            v.Add(1);
            v.Add(2);
            v.Add(3);
            v.Add(4);
            v.Add(5);
            v.Add(6);
            v.Add(7);
            v.Add(8);
            v.RemoveRange(1, 4);
            int[] expected = { 1, 6, 7, 8};
            int[] array = new int[v.Size()];
            for (int i = 0; i < v.Size(); i++)
            {
                array[i] = v[i];
            }
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
