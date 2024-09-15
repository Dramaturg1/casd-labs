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
                Form graph = new Graph(1);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test2))  
            {
                Form graph = new Graph(2);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test3))
            {
                Form graph = new Graph(3);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr1 && (comboBox2.SelectedItem.ToString() == test4))  
            {
                Form graph = new Graph(4);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test1))  
            {
                Form graph = new Graph(5);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test2)) 
            {
                Form graph = new Graph(6);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test3)) 
            {
                Form graph = new Graph(7);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr2 && (comboBox2.SelectedItem.ToString() == test4))  
            {
                Form graph = new Graph(8);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test1)) 
            {
                Form graph = new Graph(9);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test2))  
            {
                Form graph = new Graph(10);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test3))  
            {
                Form graph = new Graph(11);
                graph.Show();
            }
            if (comboBox1.SelectedItem.ToString() == gr3 && (comboBox2.SelectedItem.ToString() == test4))
            {
                Form graph = new Graph(12);
                graph.Show();
            }
        }

        public long[,] Test(int startInd, int endInd, int size, int testNumber)
        {
            int counter = 0;
            int sizeCopy = size;
            int sortNumber = endInd - startInd + 1;
            while (sizeCopy != 1)
            {
                counter++;
                sizeCopy /= 10;
            }
            Stopwatch timer = new Stopwatch();
            long[,] elapsedMS = new long[sortNumber, counter];
            int[][] baseArray = ArrayGeneration(counter, testNumber);

            Parallel.For(0, sortNumber, idx =>
            {
                int sortIndex = startInd + idx;
                if (sortIndex == 15)
                {
                    sortIndex--;
                }
                for (int j = 0; j < counter; j++)
                {
                    long totalElapsed = 0;
                    for (int k = 0; k < 20; k++)
                    {
                        int[] array = (int[])baseArray[j].Clone();
                        timer.Restart();
                        sortAlgs[sortIndex](array);
                        timer.Stop();
                        totalElapsed += timer.ElapsedMilliseconds;
                    }

                    elapsedMS[idx, j] = totalElapsed / 20;
                }
            });

            return elapsedMS;
        }

        public static int[][] ArrayGeneration(int counter, int value)
        {
            int[][] array = new int[counter][];
            for (int i = 0, size = 10; i < counter; i++, size *=10)
            {
                array[i] = new int[size];
            }
            RandomElemGeneration(array, value);
            return array;
        }

        public static void RandomElemGeneration(int[][] array, int value)
        {
            Random rand = new Random();
            
            switch(value)
            {
                case 1:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            array[i][j] = rand.Next(-999999, 1000000);
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            array[i][j] = rand.Next(-999999, 1000000);
                        }
                    }
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array[i].Length; j++)
                        {
                            array[i][j] = rand.Next(-999999, 1000000);
                        }
                    }
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                default:
                    break;
            }
        }
    }
}
