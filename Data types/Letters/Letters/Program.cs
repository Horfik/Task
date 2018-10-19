using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = {'a', 'b', 'c'};
            for (int i=2; i>=0; i--)
            {
                Console.Write(letters[i] + " ");
            }
        }
    }
}
