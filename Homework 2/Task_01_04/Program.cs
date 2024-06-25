using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_04
{
    internal class Program
    {
        static int yearcounter(int age)
        {
            int now = DateTime.Now.Year;
            return now - age;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                Console.Write("Enter your age: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("An error occured. Try again!");
                    continue;
                }
                int k = yearcounter(n);
                Console.WriteLine($"Your year of birth is {k} or {k - 1}");
                break;
            }
            Console.ReadKey();
        }
    }
}