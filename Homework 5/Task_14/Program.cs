using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age;
            try
            {
                age = Convert.ToByte(Console.ReadLine());
                if (age < 12)
                {
                    Console.WriteLine("Child");
                }
                else if (age >= 12 && age <= 16)
                {
                    Console.WriteLine("Teenager");
                }
                else if (age > 16 && age < 60)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Senior");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid age.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age.");
            }

            Console.ReadKey();
        }
    }
}