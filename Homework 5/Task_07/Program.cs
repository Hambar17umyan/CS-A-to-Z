using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            bool isRaining;
            Console.WriteLine("Enter the temperature");
            try
            {
                temperature = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Is it raining? Type true or false!");
                try
                {
                    isRaining = Convert.ToBoolean(Console.ReadLine());
                    if (temperature > 20 && !isRaining)
                    {
                        Console.WriteLine("Good weather for a walk");
                    }
                    else Console.WriteLine("Stay indoors!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid temperature.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid temperature.");
            }

            Console.ReadKey();
        }
    }
}