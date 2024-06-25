using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine($"The left edge is smaller than the right one({a} > {b}). Try again!");
                    return;
                }
                if (b <= 0)
                {
                    Console.WriteLine("Prime numbers are natural!");
                }
                else if (b > 6e8)
                {
                    Console.WriteLine("The number is too big!");
                }
                else
                {
                    bool[] isnotprime = new bool[b + 1];
                    isnotprime[1] = true;
                    for (int i = 2; i <= b; i++)
                    {
                        if (isnotprime[i] == true)
                            continue;
                        for (int j = i * 2; j <= b; j += i)
                        {
                            isnotprime[j] = true;
                        }
                    }
                    for (int i = a; i <= b; i++)
                    {
                        if (isnotprime[i] == false)
                            Console.WriteLine(i);
                    }
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