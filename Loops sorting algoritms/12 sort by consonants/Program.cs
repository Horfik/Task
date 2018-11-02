using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_sort_by_consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"kasfdg hasfajEklo", "aadkjlaa;sssdgfyuoioudghjkl", "asfgiohbdghjkl", "arthsfdghjkl", "asfdrerghjkl", "asfgvdghjkl",
            "asfdghsdjkl","asfdghjxdkl","asfdghxcbjkl","asoyfbdghjkl","asfdgtwhjkasfl","asfwerdghjkl","asfdetwghjkl","asfdsioueghjkl","asfddfgghjkl","asfdfgdghjkl","asdfgfdghjkl",
            "asfdgdfghjkl","adfgsofdghjkl","asdasdfdnjnsdfasfdghjkl"};
            char[] consonants = new char[] { 'Q', 'W', 'R', 'T', 'P', 'S', 'D', 'F', 'G', 'H',
                                         'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 
                                         'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 
                                         'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};
            int[] sum = new int[20];
            int k = 0;
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            foreach (string w in list)
            {
                for (int a = 0; a < w.Length; a++)
                {
                    foreach (char j in consonants)
                    {
                        if (w[a] == j)
                            sum[k]++;
                    }
                }
                k++;
            }
            bool b = true;
            string temp;
            while (b)
            {
                b = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (sum[i] > sum[i + 1])
                    {
                        temp = list[i + 1]; k = sum[i + 1];
                        list[i + 1] = list[i]; sum[i + 1] = sum[i];
                        list[i] = temp; sum[i] = k;
                        b = true;
                    }

                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
