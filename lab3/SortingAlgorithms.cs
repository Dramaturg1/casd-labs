﻿using System;
using System.Collections.Generic;

namespace sorting
{
    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void ShakerSort(int[] array)
        {
            bool swapped = true;
            int start = 0;
            int end = array.Length;

            while (swapped == true)
            {
                swapped = false;
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
                swapped = false;
                end = end - 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                start = start + 1;
            }
        }

        public static void CombSort(int[] array)
        {
            int length = array.Length;
            int gap = length;
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);
                swapped = false;
                for (int i = 0; i < length - gap; i++)
                {
                    if (array[i] > array[i + gap])
                    {
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
        }

        static int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
            {
                return 1;
            }
            return gap;
        }

        public static void InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        public static void ShellSort(int[] array)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array.Length; i++)
                {
                    j = i;
                    temp = array[i];
                    while ((j >= inc) && (array[j - inc] > temp))
                    {
                        array[j] = array[j - inc];
                        j = j - inc;
                    }
                    array[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        class Node
        {
            public int Data;
            public Node Left;
            public Node Right;

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        class BinarySearchTree
        {
            public Node Root;

            public BinarySearchTree()
            {
                Root = null;
            }

            public void Insert(int data)
            {
                Root = InsertRec(Root, data);
            }

            private Node InsertRec(Node root, int data)
            {
                if (root == null)
                {
                    root = new Node(data);
                    return root;
                }

                if (data < root.Data)
                    root.Left = InsertRec(root.Left, data);
                else if (data > root.Data)
                    root.Right = InsertRec(root.Right, data);

                return root;
            }


            public void InOrderTraversal(Node root, List<int> result)
            {
                if (root != null)
                {
                    InOrderTraversal(root.Left, result);
                    result.Add(root.Data);
                    InOrderTraversal(root.Right, result);
                }
            }
        }

        public static void TreeSort(int[] array)
        {
            BinarySearchTree bst = new BinarySearchTree();
            foreach (int value in array)
            {
                bst.Insert(value);
            }
            List<int> sortedList = new List<int>();
            bst.InOrderTraversal(bst.Root, sortedList);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sortedList[i];
            }
        }

        static void GnomeSort(int[] array)
        {
            int index = 0;

            while (index < array.Length)
            {
                if (index == 0)
                    index++;
                if (array[index] >= array[index - 1])
                    index++;
                else
                {
                    int temp = 0;
                    temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }
            return;
        }

        public static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (array[j] < array[min_idx])
                        min_idx = j;
                int temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
            }
        }

        public static void HeapSort(int[] array)
        {
            int N = array.Length;
            for (int i = N / 2 - 1; i >= 0; i--)
                heapify(array, N, i);
            for (int i = N - 1; i > 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                heapify(array, i, 0);
            }
        }

        static void heapify(int[] array, int N, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < N && array[l] > array[largest])
                largest = l;
            if (r < N && array[r] > array[largest])
                largest = r;
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                heapify(array, N, largest);
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    QuickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(array, pivot + 1, right);
                }
            }
        }

        static int Partition(int[] array, int left, int right)
        {

            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public static void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                // Find the middle point
                int m = l + (r - l) / 2;

                // Sort first and second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }


    }
}
