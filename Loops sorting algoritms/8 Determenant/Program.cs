using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Determenant
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[20, 20];
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

            double k;
            for (int l = 0; l < matrix.GetLength(0) - 1; l++)
            {
                for (int i = l; i < matrix.GetLength(0) - 1; i++)
                {
                    k = matrix[i + 1, l] / matrix[l, l];
                    for (int j = l; j < matrix.GetLength(1); j++)
                    {
                        matrix[i + 1, j] = matrix[i + 1, j] - k * matrix[l, j];
                    }
                }
            }

            Console.WriteLine();

            double det = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                det *= matrix[i, i];
            }
            Console.WriteLine("det = " + det);
            Console.ReadKey();
        }
    }
}
