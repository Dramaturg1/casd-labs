using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sorting;

/*
 * [TestMethod]
        public void SORT_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Sorting.SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }
 */

namespace SortingAlgorithmsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Sorting.SortingAlgorithms.BubbleSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BubbleSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.BubbleSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BubbleSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.BubbleSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BubbleSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.BubbleSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BubbleSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.BubbleSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShakerSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Sorting.SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShakerSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShakerSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShakerSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShakerSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Sorting.SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.ShakerSort(array);
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
