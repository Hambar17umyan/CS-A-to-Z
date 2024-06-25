using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the numbers a, b and c in different lines!");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());

                if (b > a)
                    a = b;
                if (c > a)
                    a = c;
                Console.WriteLine($"The maximum of those numbers is {a}.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception. Try again with different value!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format of number!");
            }

            Console.ReadKey();
        }
    }
}