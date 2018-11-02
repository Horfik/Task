using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11_Sort_by_vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"kasfdg hasfajEklo", "aadkjlaa;sssdgfyuoioudghjkl", "asfgiohbdghjkl", "arthsfdghjkl", "asfdrerghjkl", "asfgvdghjkl",
            "asfdghsdjkl","asfdghjxdkl","asfdghxcbjkl","asoyfbdghjkl","asfdgtwhjkasfl","asfwerdghjkl","asfdetwghjkl","asfdsioueghjkl","asfddfgghjkl","asfdfgdghjkl","asdfgfdghjkl",
            "asfdgdfghjkl","adfgsofdghjkl","asdasdfdnjnsdfasfdghjkl"};
            char[] vowels = new char[] {'A', 'E', 'Y', 'U', 'I', 'O', 'a', 'e', 'y', 'u', 'i', 'o' };
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
                    foreach (char j in vowels)
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
                    if (sum[i] > sum[i+1])
                    {
                        temp = list[i + 1];    k = sum[i + 1];
                        list[i + 1] = list[i]; sum[i + 1] = sum[i];
                        list[i] = temp;        sum[i] = k; 
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
