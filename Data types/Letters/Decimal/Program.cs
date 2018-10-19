using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimala
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = Convert.ToDecimal(Console.ReadLine());
            try
            {
                long a = Convert.ToInt64(number);
                Console.WriteLine(Convert.ToString(a, 2));
            }
            catch(Exception )
            {
                Console.WriteLine("Value too large or too small");
            }
            
            Console.ReadKey();
        }
    }
}

