using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                if (a == b && a == c)
                {
                    Console.WriteLine("equilateral");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("isosceles");
                }
                else
                {
                    Console.WriteLine("scalene");
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