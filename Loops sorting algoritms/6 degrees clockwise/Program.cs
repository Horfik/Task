using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_degrees_clockwise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[20, 20];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = matrix.GetLength(0)-1; j >= 0; j--)
                {
                    Console.Write(matrix[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
