﻿using System;
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
            Console.Write("Chose meter, miles, kilomeeter: ");
            string system = Console.ReadLine();
            Console.Write("enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chose seconds, minutes, hours: ");
            string timesys = Console.ReadLine();
            Console.Write("enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());
            double kilo=0; double mili=0;
            switch (system)
            {
                case "meter":
                    kilo = distance / 1000;
                    mili = distance / 1609;
                    break;
                case "miles":
                    kilo = distance*1.6;
                    mili = distance;
                    break;
                case "kilometer":
                    kilo = distance;
                    mili = distance / 1.6;
                    break;
                default:
                    Console.WriteLine("wrong typed");
                    break;
            }

            switch (timesys)
            {
                case "seconds":
                    time = time / 3600;
                    break;
                case "minutes":
                    time = time / 60;
                    break;
                case "hours":
                    break;
                default:
                    Console.WriteLine("wrong typed");
                    break;
            }
            double speadk = kilo / time;
            double speadm = mili / time;
            Console.WriteLine(speadk > 0 & speadm > 0 ? $"Spead {speadk} km/h or {speadm} mi/h" : "Enter error");
            Console.ReadKey();
        }
    }
}
