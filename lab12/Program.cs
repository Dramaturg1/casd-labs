using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab10;
using lab11;

namespace lab12
{
    internal class Program
    {
        private static int numberRequest = 1;
        private static string filePath = "log.txt";
        private static StreamWriter writer = new StreamWriter(filePath);

        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.GetEncoding(1251);
                int n = Convert.ToInt32(Console.ReadLine());
                MyPriorityQueue<MyRequest> queue = new MyPriorityQueue<MyRequest>();
                for (int i = 1; i < n + 1; i++)
                {
                    Random rnd = new Random();
                    int countRequests = rnd.Next(1, 10);
                    for (int j = 0; j < countRequests; j++)
                    {
                        GenerateRequest(queue, i);
                    }
                    MyRequest maxRequest = queue.Element();
                    queue.Remove(maxRequest);
                    writer.WriteLine("REMOVE " + maxRequest.Number + " " + maxRequest.Priority + " " + maxRequest.Step);
                }
                System.TimeSpan time = new TimeSpan();
                int pr = 0, st = 0, num = 0;
                while (!queue.IsEmpty())
                {
                    MyRequest req = queue.Element();
                    time = req.Stopwatch.Elapsed;
                    pr = req.Priority;
                    st = req.Step;
                    num = req.Number;
                    queue.Remove(req);
                    writer.WriteLine("REMOVE " + req.Number + " " + req.Priority + " " + req.Step);
                }
                queue = null;
                Console.WriteLine(num + " " + pr + " " + st + " " + time);
                writer.Close();
                Console.WriteLine("Data has been updated in " + Directory.GetCurrentDirectory() + "\\log.txt");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
        private static void GenerateRequest(MyPriorityQueue<MyRequest> queue, int step)
        {

            Random rnd = new Random();
            int countRequests = rnd.Next(1, 10);

            for (int i = 0; i <= countRequests; i++)
            {
                int priority = rnd.Next(1, 5);
                MyRequest request = new MyRequest(priority, numberRequest, step);
                numberRequest++;
                queue.Add(request);
                writer.WriteLine("ADD " + request.Number + " " + request.Priority + " " + request.Step);
            }
        }
    }
}