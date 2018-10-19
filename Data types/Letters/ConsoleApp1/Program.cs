using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int k=width;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(width);
                }
                Console.WriteLine();
                k--;
            }
            Console.ReadKey();
        }
    }
}
