using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Sofok/source/repos/lab7/lab7/bin/Debug/input.txt";
            string[] adr = File.ReadAllLines(path);
            Console.WriteLine("Input.txt:");
            for (int i = 0; i < adr.Length; i++)
            {
                Console.Write(adr[i]);
            }
            Console.WriteLine("\nCorrect IP adresses:");
            lab6.MyVector<string> v = new lab6.MyVector<string>();
            string temp = "";
            for (int i = 0; i < adr.Length; i++)
            {
                for (int j = 0; j < adr[i].Length; j++)
                {
                    if (!(adr[i][j].Equals('.')))
                    {
                        temp += adr[i][j];
                    }
                    else
                    {
                        v.Add(temp);
                        temp = "";
                    }
                }

            }
            lab6.MyVector<string> ip = new lab6.MyVector<string>();
            string res ="";
            int count = 0;
            for (int i = 0; i < v.Size(); i++)
            {
                int buff = Convert.ToInt32(v[i]);
                if (buff <= 255)
                {
                    if (count < 4)
                    {
                        res += v[i] + '.';
                        count++;
                    }
                    else
                    {
                        ip.Add(res);
                        res = v[i] + '.';
                        count = 1;
                    }
                }
                else
                {
                    res = "";
                    count = 0;
                }
            }
            for (int i = 0; i < ip.Size(); i++)
            {
                Console.WriteLine(ip[i]);
            }
            Console.ReadLine();
        }
    }
}
