using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tagValue = new List<string>();
            Stack<char> tags = new Stack<char>();
            string path = "C:/Users/Sofok/source/repos/lab5/lab5/bin/Debug/input.txt";
            using (StreamReader file = new StreamReader(path))
            {
                string temp;
                while ((temp = file.ReadLine()) != null)
                {
                    Console.WriteLine(temp);
                    string value = "";
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] == '<')
                        {
                            tags.Push(temp[i]);
                        }
                        else if (temp[i] == '>')
                        {
                            tags.Pop();
                            if (!string.IsNullOrEmpty(value))
                            {
                                tagValue.Add(value);
                                value = "";
                            }
                        }
                        else if (temp[i] != '/' && temp[i] != ' ')
                        {
                            value += temp[i];
                        }
                    }
                }
            }
            HashSet<string> strings = new HashSet<string>();
            for (int i = 0; i < tagValue.Count; i++)
            {
                tagValue[i] = tagValue[i].ToLower();
                strings.Add(tagValue[i]);
            }
            foreach (string s in strings)
            {
                Console.Write(s + " ");
            }
            
            Console.ReadLine();
        }
    }
}
