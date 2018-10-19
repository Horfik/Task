using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowel = new char[] {'a', 'A', 'e', 'E', 'y', 'Y', 'u', 'U', 'i', 'I', 'o', 'O' };
            char[] consonant = new char[] { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'b', 'v', 'c', 'x', 'z', 'Q', 'W', 'R', 'T', 'P', 'L', 'K', 'J', 'H', 'G', 'F', 'D', 'S', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            char[] numeral = new char[] {'1','2','3','4','5','6','7','8','9','0' };
            char character = Convert.ToChar(Console.ReadLine());
            if (vowel.Contains(character))
                Console.WriteLine("Vowel");
            else if (consonant.Contains(character))
                Console.WriteLine("Consonant");
            else if (numeral.Contains(character))
                Console.WriteLine("Numeral");
            else Console.WriteLine("Other character");
            Console.ReadKey();
        }
    }
}
