using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius,2);
            double perimeter = Math.PI * 2 * radius;
            Console.WriteLine($"The circle has area: {area} and perimeter {perimeter}");
            Console.ReadKey();
        }
    }
}
