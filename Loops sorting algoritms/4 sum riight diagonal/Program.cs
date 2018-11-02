using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_sum_riight_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[20, 20];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                        sum += matrix[i, j];
                }
            }
            Console.WriteLine("Summa: " + sum);
            Console.ReadKey();
        }
    }
}
