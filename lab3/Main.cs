using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        public delegate void SortDelegate(int[] array);

        List<SortDelegate> sortAlgs = new List<SortDelegate>
            {
                sorting.SortingAlgorithms.BubbleSort, //0
                sorting.SortingAlgorithms.InsertionSort, //1
                sorting.SortingAlgorithms.SelectionSort, //2
                sorting.SortingAlgorithms.ShakerSort, //3
                sorting.SortingAlgorithms.GnomeSort, //4
                sorting.SortingAlgorithms.BitonicSort, //5
                sorting.SortingAlgorithms.ShellSort, //6
                sorting.SortingAlgorithms.TreeSort, //7
                sorting.SortingAlgorithms.CombSort, //8
                sorting.SortingAlgorithms.HeapSort, //9
                sorting.SortingAlgorithms.QuickSort, //10
                sorting.SortingAlgorithms.MergeSort, //11
                sorting.SortingAlgorithms.CountingSort, //12
                sorting.SortingAlgorithms.BucketSort, //13
                sorting.SortingAlgorithms.RadiaxSort, //14
            };

        private void button1_Click(object sender, EventArgs e)
        {
            string gr1 = "Группа №1 (BubbleSort, InsertionSort, SelectionSort, ShakerSort, GnomeSort)";
            string gr2 = "Группа №2 (BitonicSort, ShellSort, TreeSort)";
            string gr3 = "Группа №3 (CombSort, HeapSort, QuickSort, MergeSort, CountingSort, BucketSort, RadiaxSort)";
            string test1 = "Массивы случайных чисел";
            string test2 = "Массивы с отсортированными подмассивами";
            string test3 = "Отсортированные массивы с перестановками";
            string test4 = "Массивы с повторениями; массивы, остортированные прямо и обратно";
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Не были выбраны тестовые данные");
                return;
            }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test1))
            {
                Form graph = new Graph();
                graph.Show();
                long[,] elapsedMS = new long[5, 5];
                elapsedMS = Group1Test1();

            }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test2))   { }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test3))   { }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test4))   { }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test1))   { }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test2))   { }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test3))   { }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test4))   { }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test1))   { }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test2))   { }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test3))   { }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test4))   { }

        }
        /*
        public long[,] Group1Test1()
        {
            Random rand = new Random();
            Stopwatch timer = new Stopwatch();
            long[,] elapsedMS = new long[5,5];
            for (int i = 0; i < 5; i++)
            {
                int[] baseArray = new int[100000];
                for (int j = 0; j < baseArray.Length; j++)
                {
                    if (i == 0)
                    {
                        baseArray[j] = rand.Next(-9, 10);
                    }
                    if (i == 1)
                    {
                        baseArray[j] = rand.Next(-999, 1000);
                    }
                    if (i == 2)
                    {
                        baseArray[j] = rand.Next(-99999, 100000);
                    }
                    if (i == 3)
                    {
                        baseArray[j] = rand.Next(-9999999, 10000000);
                    }
                    if (i == 4)
                    {
                        baseArray[j] = rand.Next(-999999999, 1000000000);
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    timer.Start();
                    for (int k = 0; k < 20; k++)
                    {
                        int[] array = (int[])baseArray.Clone();
                        sortAlgs[j](array);
                    }
                    timer.Stop();
                    elapsedMS[i, j] += timer.ElapsedMilliseconds;
                    timer.Reset();

                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    elapsedMS[i, j] /= 20;
                }
            }
            return elapsedMS;
        }
        */

        public long[,] Group1Test1()
        {
            Random rand = new Random();
            Stopwatch timer = new Stopwatch();
            long[,] elapsedMS = new long[5, 5];

            int[][] testData = new int[5][];
            testData[0] = Enumerable.Range(0, 100000).Select(_ => rand.Next(-9, 10)).ToArray();
            testData[1] = Enumerable.Range(0, 100000).Select(_ => rand.Next(-999, 1000)).ToArray();
            testData[2] = Enumerable.Range(0, 100000).Select(_ => rand.Next(-99999, 100000)).ToArray();
            testData[3] = Enumerable.Range(0, 100000).Select(_ => rand.Next(-9999999, 10000000)).ToArray();
            testData[4] = Enumerable.Range(0, 100000).Select(_ => rand.Next(-999999999, 1000000000)).ToArray();

            int[] buffer = new int[100000];

            Parallel.For(0, 5, i =>
            {
                for (int j = 0; j < 5; j++)
                {
                    var startTime = DateTime.Now;
                    for (int k = 0; k < 20; k++)
                    {
                        Array.Copy(testData[i], buffer, 100000);
                        sortAlgs[j](buffer);
                    }
                    var elapsed = DateTime.Now - startTime;
                    elapsedMS[i, j] = (long)elapsed.TotalMilliseconds;
                }
            });

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    elapsedMS[i, j] /= 20;
                }
            }

            return elapsedMS;
        }

        public void DrawGraph()
        {

        }
    }
}
