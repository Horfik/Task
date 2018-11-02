using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Change_place
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
            string cr;
            for (int i = 0; i < list.Count; i++)
            {
                cr = Convert.ToString(list[i][0]);
                list[i] = list[i].Remove(0, 1);
                list[i] = list[i].Insert(0, Convert.ToString(list[i][list[i].Length-1]));
                list[i] = list[i].Remove(list[i].Length-1, 1);
                list[i] = list[i].Insert(list[i].Length, cr);
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
