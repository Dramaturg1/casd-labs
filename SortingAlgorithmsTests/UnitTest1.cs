using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sorting;

/*
 * [TestMethod]
        public void SORT_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Sorting.SortingAlgorithms.Sort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.Sort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.Sort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.Sort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SORT_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.Sort(array);
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
            sorting.SortingAlgorithms.BubbleSort(array);
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
            sorting.SortingAlgorithms.ShakerSort(array);
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
        public void CombSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.CombSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CombSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.CombSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CombSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.CombSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CombSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.CombSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CombSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.CombSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void InsertionSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.InsertionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void InsertionSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.InsertionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void InsertionSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.InsertionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void InsertionSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.InsertionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void InsertionSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.InsertionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShellSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.ShellSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShellSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.ShellSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShellSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.ShellSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShellSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.ShellSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ShellSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.ShellSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TreeSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.TreeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TreeSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.TreeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TreeSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.TreeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TreeSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.TreeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void TreeSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.TreeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void GnomeSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.GnomeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void GnomeSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.GnomeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void GnomeSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.GnomeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void GnomeSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.GnomeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void GnomeSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.GnomeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SelectionSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.SelectionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SelectionSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.SelectionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SelectionSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.SelectionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SelectionSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.SelectionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void SelectionSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.SelectionSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.HeapSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.HeapSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.HeapSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.HeapSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void HeapSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.HeapSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.QuickSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.QuickSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.QuickSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.QuickSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void QuickSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.QuickSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void MergeSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.MergeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void MergeSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.MergeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void MergeSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.MergeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void MergeSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.MergeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void MergeSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.MergeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.CountingSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BucketSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.BucketSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BucketSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.BucketSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BucketSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.BucketSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BucketSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.BucketSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BucketSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.BucketSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadiaxSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.RadiaxSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadiaxSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.RadiaxSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadiaxSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.RadiaxSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadiaxSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.RadiaxSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadiaxSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.RadiaxSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BitonicSort_ShouldTestCorrectly()
        {
            int[] array = { 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8 };
            sorting.SortingAlgorithms.BitonicSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BitonicSort_Empty()
        {
            int[] array = { };
            int[] expected = { };
            SortingAlgorithms.BitonicSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BitonicSort_SingleElement()
        {
            int[] array = { 1 };
            int[] expected = { 1 };
            SortingAlgorithms.BitonicSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BitonicSort_Duplictes()
        {
            int[] array = { 5, 5, 4, 3, 2, 2, 1, 1 };
            int[] expected = { 1, 1, 2, 2, 3, 4, 5, 5 };
            SortingAlgorithms.BitonicSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void BitonicSort_AlreadySorted()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };
            SortingAlgorithms.BitonicSort(array);
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
