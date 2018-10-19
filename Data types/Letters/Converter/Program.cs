using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Chose meter, mili, kilomeeter: ");
            string system = Console.ReadLine();
            Console.Write("enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chose seconds, minuts, hours: ");
            string timesys = Console.ReadLine();
            Console.Write("enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());
            double kilo=0; double mili=0;
            switch (system)
            {
                case "meter":
                    kilo = distance/1000;
                    mili = distance / 1609;
                    break;
                case "mili":
                    kilo = distance*1.6;
                    mili = distance;
                    break;
                case "kilometer":
                    kilo = distance;
                    mili = distance / 1.6;
                    break;
            }

            switch (timesys)
            {
                case "seconds":
                    time = time / 3600;
                    break;
                case "minuts":
                    time = time / 60;
                    break; 
            }
            Console.WriteLine($"Spead {0} km/h or {1} mi/h", (kilo/time), (mili/time));
            Console.ReadKey();
        }
    }
}
