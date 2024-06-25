using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long n = long.Parse(Console.ReadLine());
                long l = 1;
                if (n < 0)
                {
                    Console.WriteLine("Undefined");
                }
                else if (n > 20)
                {
                    Console.WriteLine("The number is too big!");
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        l *= i;
                    }
                    Console.WriteLine(l);
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