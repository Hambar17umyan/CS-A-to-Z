using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string(' ', n - i));
                    for (int j = 1; j < i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write('*');
                    Console.Write(new string(' ', n - i));
                    Console.WriteLine();
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid data type. The number may be too big or too small.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid data type. Make sure that you have entered a valid NATURAL number.");
            }

        }
    }
}