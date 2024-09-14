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

        private long[] RandMod10()
        {
            Stopwatch timer = new Stopwatch();
            Random rand = new Random();
            long[] elapsedMS = new long[15];
            foreach (long i in elapsedMS)
            {
                elapsedMS[i] = 0;
            };



            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int[] array = new int[100000];
                    for (int k = 0; k < array.Length; k++)
                    {
                        array[k] = rand.Next(-9, 9);
                    }
                    timer.Start();
                    sortAlgs[i](array);
                    timer.Stop();
                    elapsedMS[i] += timer.ElapsedMilliseconds;
                    timer.Reset();
                }

            }
            foreach (int i in elapsedMS)
            {
                elapsedMS[i] /= 20;
            }
            return elapsedMS;
        }
    }
}
