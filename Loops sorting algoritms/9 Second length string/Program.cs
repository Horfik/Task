using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Second_length_string
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"asfdghasfjkl", "aadkjlaa;sssdgfdghjkl", "asfghbdghjkl", "arthsfdghjkl", "asfdrerghjkl", "asfgvdghjkl",
            "asfdghsdjkl","asfdghjxdkl","asfdghxcbjkl","asfbdghjkl","asfdgtwhjkl","asfwerdghjkl","asfdetwghjkl","asfdseghjkl","asfddfgghjkl","asfdfgdghjkl","asdfgfdghjkl",
            "asfdgdfghjkl","adfgsfdghjkl","asdasdfdnjnsdfasfdghjkl"};
            int max=0;
            foreach (string i in list)
            {
                Console.WriteLine(i);
                if (i.Length > max)
                    max = i.Length;
            }
            
            Console.WriteLine();
            string a=list[0];
            foreach (string i in list)
            {
                 if (max > i.Length && i.Length >= a.Length)
                     a = i;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
