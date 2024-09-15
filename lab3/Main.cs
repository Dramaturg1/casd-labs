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

        public long[,] Group1Test1()
        {
            Stopwatch timer = new Stopwatch();
            long[,] elapsedMS = new long[5, 4];
            int[][] baseArray = ArrayGeneration();

            Parallel.For(0, 5, i =>
            {
                for (int j = 0; j < 4; j++)
                {
                    long totalElapsed = 0;
                    for (int k = 0; k < 20; k++)
                    {
                        int[] array = (int[])baseArray[j].Clone();
                        timer.Restart();
                        sortAlgs[i](array);
                        timer.Stop();
                        totalElapsed += timer.ElapsedMilliseconds;
                    }

                    elapsedMS[i, j] = totalElapsed / 20;
                }
            });

            return elapsedMS;
        }

        public static int[][] ArrayGeneration()
        {
            int[][] array = new int[4][];
            array[0] = new int[10];
            array[1] = new int[100];
            array[2] = new int[1000];
            array[3] = new int[10000];
            RandomElemGeneration(array, 1000);
            return array;
        }

        public static void RandomElemGeneration(int[][] array, int module)
        {
            Random rand = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(-module+1, module+1);
                }
            }
        }
    }
}
