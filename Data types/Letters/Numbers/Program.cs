using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]  numbers = new int[2];
            Console.Write("Enter the first number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 2; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine($"{i+1} number even");
                else Console.WriteLine($"{i+1} number odd");
            }
            
            Console.ReadKey();
        }
    }
}
