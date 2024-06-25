using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine($"{number} is positive.");
                }
                else if (number == 0)
                {
                    Console.WriteLine($"{number} is zero.");
                }
                else
                {
                    Console.WriteLine($"{number} is negative.");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            Console.ReadKey();
        }
    }
}