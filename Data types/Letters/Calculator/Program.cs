using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operation: ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    Console.WriteLine(first + second);
                    break;
                case '-':
                    Console.WriteLine(first - second);
                    break;
                case '*':
                    Console.WriteLine(first * second);
                    break;
                case '/':
                    Console.WriteLine(first / second);
                    break;
                case 'x':
                    Console.WriteLine(first * second);
                    break;
                default:
                    Console.WriteLine("Operation not found");
                    break;
            }
            Console.ReadKey();
        }
    }
}
