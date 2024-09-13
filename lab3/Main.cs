using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form basicArray = new BasicSort();
            basicArray.Show();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Form subarrays = new Subarrays();
            subarrays.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Form sortedArrays = new SortedArray();
            sortedArrays.Show();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            Form duplicates = new Duplicates();
            duplicates.Show();
        }
    }
}
