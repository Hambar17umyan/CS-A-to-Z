using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string name, surname, profession;
                int age;
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                Console.Write("Please enter your surname: ");
                surname = Console.ReadLine();
                Console.Write("Please enter your age: ");
                while (true)
                {
                    string s = Console.ReadLine();
                    bool b = true;
                    for (var i = 0; i < s.Length; i++)
                    {
                        if (!(s[i] >= '0' && s[i] <= '9'))
                        {
                            b = false;
                            break;
                        }
                    }
                    if (b)
                    {
                        age = Convert.ToInt32(s);
                        break;
                    }

                    Console.WriteLine("You've entered another data type. PLease provide me a valid number");
                }
                Console.Write("Finally, enter your profession: ");
                profession = Console.ReadLine();

                Console.WriteLine($"So to sum it up, let's review the information.\nYou are {name} {surname} and your profession is {profession}. You are {age} years old.\nAre there any typos or mistakes in this data.\nIf you've detected some mistakes, please write something on the console. Otherwise you can type 'ok' to drop the program.");
                string status = Console.ReadLine();
                if (status == "ok")
                    break;
                else
                {
                    Console.WriteLine("OK! Let us review the information!");
                }
            }
            Console.WriteLine("OK. Your registeration is complete.");
            Console.ReadKey();
        }
    }
}