using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y <= 5 & 5 >= -5)
            {
                Console.WriteLine("x = " + (y * y + 2 * y + 1));
            }
            else { Console.WriteLine("y is out of range"); }
            Console.ReadKey();
        }
    }
}
