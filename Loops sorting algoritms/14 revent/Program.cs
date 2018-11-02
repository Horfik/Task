using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_revent
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> {"kasfdg hasfajEklo", "aadkjlaa;sssdgfyuoioudghjkl", "asfgiohbdghjkl", "arthsfdghjkl", "asfdrerghjkl", "asfgvdghjkl",
            "asfdghsdjkl","asfdghjxdkl","asfdghxcbjkl","asoyfbdghjkl","asfdgtwhjkasfl","asfwerdghjkl","asfdetwghjkl","asfdsioueghjkl","asfddfgghjkl","asfdfgdghjkl","asdfgfdghjkl",
            "asfdgdfghjkl","adfgsofdghjkl","asdasdfdnjnsdfasfdghjkl"};
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            
            List<string> list1 = new List<string> {"","","","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            for(int i = 0; i < list.Count; i++)
            {
                for (int j = list[i].Length-1; j>=0; j--)
                {
                    list1[i] += Convert.ToString(list[i].Last());
                    list[i] = list[i].Remove(list[i].Length - 1, 1);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (string i in list1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
