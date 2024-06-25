using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Type the starting number of the range: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type the ending number of the range: ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a % 2 != 0)
                {
                    a++;
                }
                for (int i = a; i <= b; i += 2)
                {
                    Console.Write(i);
                    Console.Write(' ');
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Something went wrong. Please try again!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Something went wrong. Please try again!");
            }
        }
    }
}