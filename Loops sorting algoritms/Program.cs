using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_element
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mass= new double[20];
            Console.Write("Enterr number element:");
            int a = Convert.ToInt32(Console.ReadLine())-1;
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.NextDouble();
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            
            for (int i=a; a < mass.Length-1; a++)
            {
                 mass[a] = mass[a + 1];
            }
            Array.Resize(ref mass, mass.Length - 1);
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write(mass[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
