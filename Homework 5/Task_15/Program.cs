using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
                if (b > a)
                {
                    a = b;
                }
                if (c > a)
                {
                    a = c;
                }
                if (d > a)
                {
                    a = d;
                }
                Console.WriteLine(a);
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