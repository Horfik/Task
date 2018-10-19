using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = Convert.ToInt32(Console.ReadLine());
            double volume = (4 * Math.PI * Math.Pow(radius, 3))/3;
            double surface = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"the sphere has volume: {volume} and surface: {surface}");
            Console.ReadKey();
        }
    }
}
