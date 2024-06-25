using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                if (number < 50)
                {
                    Console.WriteLine($"The number {number} is greater than 0 and less than 50.");
                }
                else if (number == 50)
                {
                    Console.WriteLine($"The number {number} is equal to 50.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is greater than 50.");
                }
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is equal to 0.");
            }
            else
            {
                Console.WriteLine($"The number {number} is less than 0.");
            }

            Console.ReadKey();
        }
    }
}