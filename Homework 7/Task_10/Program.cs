using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 100);
            Console.WriteLine("I've selected a number in range of [1, 100]. Try to guess it");
            int guess = 0;
            int count = 0;
            while (guess != n)
            {
                count++;
                try
                {
                    guess = int.Parse(Console.ReadLine());
                    if (guess > 100 || guess < 1)
                    {
                        count--;
                        Console.WriteLine("The number you have entered is too big or too small. Please enter a number in range of [0, 100]!");
                    }
                    else
                    {
                        if (n > guess)
                        {
                            Console.WriteLine("Failed attempt!!!\nYour number is too small. Try a bigger one.");
                        }
                        else if (n < guess)
                        {
                            Console.WriteLine("Failed attempt!!!\nYour number is too big. Try a smaller one.");
                        }
                        else
                        {
                            Console.WriteLine($"Congratulations!!! You got it!\nYou have guessed the number with {count} attempts");
                        }
                    }
                }
                catch (FormatException)
                {
                    count--;
                    Console.WriteLine("The inout is invalid. Please enter a number in range of[0, 100]!");
                }
                catch (OverflowException)
                {
                    count--;
                    Console.WriteLine("The number you have entered is too big or too small. Please enter a number in range of [0, 100]!");
                }
            }
        }
    }
}