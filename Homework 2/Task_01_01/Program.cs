using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_01
{
    internal class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine(name);
            Console.WriteLine(surname);
            Console.WriteLine(profession);
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}