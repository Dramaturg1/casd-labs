using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("data.txt");
            int dim = int.Parse(lines[0]);
            double[] vec = Array.ConvertAll(lines[1].Split(' '), double.Parse);
            double[,] matrix = new double[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                string[] row = lines[i + 2].Split(' ');
                for (int j = 0; j < dim; j++)
                {
                    matrix[i, j] = double.Parse(row[j]);
                }
            }
            if (IsSymmetrical(ref matrix, dim))
            {
                Console.WriteLine("Длина вектора ({0}) в {1}-мерном пространстве - {2}", string.Join(",", vec), dim, LengthCalculation(ref matrix, dim, ref vec));
                Console.ReadLine();
            }

            else
                Console.WriteLine("Матрица тензоран не симметрична");
        }

        static bool IsSymmetrical(ref double[,] matrix, int dim)
        {
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        return false;
                }
            }
            return true;
        }

        static double LengthCalculation(ref double[,] matrix, int dim, ref double[] vec)
        {
            double[] temp = new double[dim];
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    temp[i] += matrix[i, j] * vec[j];
                }
            }
            double result = 0.0;
            for (int i = 0; i < dim; i++)
            {
                result += temp[i] * vec[i];
            }

            return Math.Sqrt(result);
        }
    }
}