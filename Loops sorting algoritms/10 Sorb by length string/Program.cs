using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sorb_by_length_string
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "12" , "123" , "1234" , "1111111111111" ,"111111111111" , "111111" , "1111111", "11111111",
                "11111111" , "111111111" , "1111111111" , "11111111111" ,"11111111111111111"  , "111111111111" , 
                "111111111111" , "1111111111111" ,"12345","1", "11111111111111" ,  "11111111111"};
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            bool b = true;
            string temp;
            while (b)
            {
                b = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].Length > list[i+1].Length)
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                        b = true;
                    }
                    
                }
            }
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
