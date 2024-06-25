using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long n = long.Parse(Console.ReadLine());
                long l = 1;
                if (n <= 0)
                {
                    Console.WriteLine("Undefined");
                }
                else if (n > 92)
                {
                    Console.WriteLine("The number is too big!");
                }
                else
                {
                    long a, b;
                    a = 1;
                    b = 1;
                    if (n == 1)
                    {
                        Console.WriteLine($"F_{n} = {b}");
                    }
                    else if (n == 2)
                    {
                        Console.WriteLine($"F_{1} = {b}");
                        Console.WriteLine($"F_{n} = {b}");
                    }
                    else
                    {
                        Console.WriteLine($"F_{1} = {b}");
                        Console.WriteLine($"F_{n} = {b}");
                        for (int i = 3; i <= n; i++)
                        {
                            a += b;
                            a = b - a;
                            b -= a;
                            a += b;
                            Console.WriteLine($"F_{i} = {b}");
                        }
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid data type. The number may be too big or too small.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid data type. Make sure that you have entered a valid number.");
            }

        }
    }
}