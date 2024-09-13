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

        delegate void SortDelegate(int[] array);

        private long RandMod10()
        {
            Stopwatch timer = new Stopwatch();
            Random rand = new Random();
            long elapsedMS = 0;
            List<SortDelegate> sortAlgs = new List<SortDelegate>
            {
                sorting.SortingAlgorithms.BubbleSort, sorting.SortingAlgorithms.
            }
            for (int i = 0; i < 20; i++)
            {
                int[] arr = new int[100000];
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[i] = rand.Next(-9, 9);
                }
                timer.Start();
                sorting.SortingAlgorithms.BubbleSort(arr);
                timer.Stop();
                elapsedMS += timer.ElapsedMilliseconds;
            }
            return elapsedMS /= 20;
        }
    }
}
