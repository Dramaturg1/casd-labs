using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Programm
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            lab4.MyArrayList<int> list = new lab4.MyArrayList<int>(array);
            var subList = list.SubList(1, 3);
            int[] expected = { 2, 3, 4 };
            int[] actual = subList.ToArray();
            for (int i = 0; i < actual.Length; i++)
            {
                Console.Write(actual[i] + " ");
            }
            Console.ReadLine();
        }
    }
}