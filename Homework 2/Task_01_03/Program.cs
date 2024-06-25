using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_03
{
    internal class Program
    {
        static int agecounter(int year)
        {
            int now = DateTime.Now.Year;
            return now - year;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                Console.Write("Enter your year of birth: ");
                n = Convert.ToInt32(Console.ReadLine());
                int k = agecounter(n);
                if (k < 0)
                {
                    Console.WriteLine("An error occured. Try again!");
                }
                else
                {
                    Console.WriteLine($"You are {k} or {k - 1} years old!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}