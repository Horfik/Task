using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> User = new Dictionary<string, string>
            {
                ["Sergey"] = "123a",
                ["Alex"] = "123b"
            };
            string name;
            string password;
            byte k = 0;
            while (k<3)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                if (User.ContainsKey(name))
                {
                    if (User[name] == password) 
                    {
                        Console.WriteLine("Congratulation");
                        break;
                    }
                }
                
                k++;
                Console.WriteLine("name or password is not correct! Try again");
            }
            Console.ReadKey();
        }
    }
}
