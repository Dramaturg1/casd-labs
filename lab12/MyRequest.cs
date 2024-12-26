using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    internal class MyRequest : IComparable<MyRequest>
    {
        private int priority;
        private int number;
        private int step;
        private Stopwatch stopwatch;

        public int Priority => priority;
        public int Number => number;
        public int Step => step;
        public Stopwatch Stopwatch => stopwatch;

        public MyRequest(int priority, int number, int step)
        {
            this.priority = priority;
            this.number = number;
            this.step = step;
            this.stopwatch = Stopwatch.StartNew();
        }
        public int CompareTo(MyRequest other)
        {
            if (other == null)
                return 1;
            return this.priority.CompareTo(other.priority);
        }
    }
}
