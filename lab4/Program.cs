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
            MyArrayList<string> list = new MyArrayList<string>();
            list.Add("sdfsf");
            list.Add("sdadad");
            list.Add("sdsssssss");
            for (int i = 0; i < list.GetSize(); i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}