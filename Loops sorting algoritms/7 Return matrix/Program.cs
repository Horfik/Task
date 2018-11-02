using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = new double[20, 20];
            double[,] returns = new double[20, 20];
            Random rnd = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    if (i == j)
                        returns[i, j] = 1;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            double k = matrix[0, 0] == 0 ? 1 : 1 / matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[0, i] = matrix[0, i] * k;
                returns[0, i] = returns[0, i] * k;
            }

            for (int l = 0; l < matrix.GetLength(0) - 1; l++)
            {
                for (int i = l; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i + 1, l] != 0)
                    {
                        k = matrix[i + 1, l];
                        for (int j = l; j < matrix.GetLength(1); j++)
                        {
                            matrix[i + 1, j] = matrix[i + 1, j] - k;
                            returns[i + 1, j] = returns[i + 1, j] - k;
                        }
                    }
                }
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] != 1)
                {
                    k = matrix[i, i] == 0 ? 1 : 1 / matrix[i, i];
                    matrix[i, i] = matrix[i, i] == 0 ? 1 : k * matrix[i, i];
                    for (int j = i + 1; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] + k;
                        returns[i, j] = returns[i, j] + k;
                    }
                }
            }

            for (int l = matrix.GetLength(0) - 1; l >= 1; l--)
            {
                for (int i = l; i >= 1; i--)
                {
                    if (matrix[i - 1, l] != 0)
                    {
                        k = matrix[i - 1, l];
                        for (int j = l; j >= l; j--)
                        {
                            matrix[i - 1, j] = matrix[i - 1, j] - k;
                            returns[i - 1, j] = returns[i - 1, j] - k;
                        }
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(returns[i, j].ToString("0.0") + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
