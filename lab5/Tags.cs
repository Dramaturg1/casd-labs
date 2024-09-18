using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using lab4;


namespace lab5
{
    internal class Tags
    {
        static void Main(string[] args)
        {
            lab4.MyArrayList<string> tagValue = new lab4.MyArrayList<string>();
            lab4.MyArrayList<char> tags = new lab4.MyArrayList<char>();
            string path = "C:/Users/Sofok/source/repos/lab5/lab5/bin/Debug/input.txt";
            using (StreamReader file = new StreamReader(path))
            {
                string temp;
                while ((temp = file.ReadLine()) != null)
                {
                    Console.WriteLine(temp);
                    string value = "";
                    int ind = 0;
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (temp[i] == '<')
                        {
                            tags.Add(temp[i]);
                            ind++;
                        }
                        else if (temp[i] == '>')
                        {
                            tags.Remove(ind--);
                            if (!string.IsNullOrEmpty(value))
                            {
                                tagValue.Add(value);
                                value = "";
                            }
                        }
                        else if (!tags.IsEmpty() && temp[i] != '/' && temp[i] != ' ')
                        {
                            value += temp[i];
                        }
                    }
                }
            }

            for (int i = 0; i < tagValue.Size(); i++)
            {
                tagValue[i] = tagValue[i].ToLower();
            }

            MyArrayList<string> resultList = new MyArrayList<string>();
            
            for (int i = 0; i < tagValue.Size(); i++)
            {
                if (!resultList.Contains(tagValue[i]))
                {
                    resultList.Add(tagValue[i]);
                }
            }

            for (int i = 0; i < resultList.Size(); i++)
            {
                Console.Write(resultList[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}
