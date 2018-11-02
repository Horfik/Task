using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Multiplication_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[20, 20];
            int[,] matrix1 = new int[20, 20];
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    matrix1[i, j] = rnd.Next(10);
                    Console.Write(matrix[i, j] + " ");
                }
               
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    matrix1[i, j] = rnd.Next(10);
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i,j]* matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
