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
    public partial class BasicSort : Form
    {
        public BasicSort()
        {
            InitializeComponent();
        }

        delegate void SortDelegate(object parameters);

        private long[] RandMod10()
        {
            Stopwatch timer = new Stopwatch();
            Random rand = new Random();
            long[] elapsedMS = new long[15];
            foreach (long i in elapsedMS)
            {
                elapsedMS[i] = 0;
            };

            List<SortDelegate> sortAlgs = new List<SortDelegate>
            {
                param => sorting.SortingAlgorithms.BubbleSort((int[])param),
                param => sorting.SortingAlgorithms.ShakerSort((int[])param),
                param => sorting.SortingAlgorithms.CombSort((int[])param),
                param => sorting.SortingAlgorithms.InsertionSort((int[])param),
                param => sorting.SortingAlgorithms.ShellSort((int[])param),
                param => sorting.SortingAlgorithms.TreeSort((int[])param),
                param => sorting.SortingAlgorithms.GnomeSort((int[])param),
                param => sorting.SortingAlgorithms.SelectionSort((int[])param),
                param => sorting.SortingAlgorithms.HeapSort((int[])param),
                param => sorting.SortingAlgorithms.QuickSort(((Tuple<int[], int, int>)param)),
                param => sorting.SortingAlgorithms.MergeSort((())),
                param => sorting.SortingAlgorithms.CountingSort((int[])param),
                param => sorting.SortingAlgorithms.BucketSort((())),
                param => sorting.SortingAlgorithms.RadiaxSort((int[])param),
                param => sorting.SortingAlgorithms.BitonicSort((int[])param)
            };
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int[] array = new int[100000];
                    foreach (int k in array)
                    {
                        array[k] = rand.Next(-9, 10);
                    }
                    timer.Start();
                    sortAlgs[i](array);
                    timer.Stop();
                    elapsedMS[i] = timer.ElapsedMilliseconds;
                }

            }
            foreach (long i in elapsedMS)
            {
                elapsedMS[i] /= 20;
            }
            return elapsedMS;
        }
    }
}
