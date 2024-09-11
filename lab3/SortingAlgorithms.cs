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


    }
}
