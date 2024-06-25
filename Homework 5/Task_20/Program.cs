using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                d = Convert.ToInt32(Console.ReadLine());
                e = Convert.ToInt32(Console.ReadLine());
                int mx, mn;
                mx = a;
                mn = a;
                if (b < mn)
                {
                    mn = b;
                }
                if (c < mn)
                {
                    mn = c;
                }
                if (d < mn)
                {
                    mn = d;
                }
                if (e < mn)
                {
                    mn = e;
                }

                if (b > mx)
                {
                    mx = b;
                }
                if (c > mx)
                {
                    mx = c;
                }
                if (d > mx)
                {
                    mx = d;
                }
                if (e > mx)
                {
                    mx = e;
                }
                Console.WriteLine($"The minimum is {mn} and the maximum is {mx}.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid age.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age.");
            }

            Console.ReadKey();
        }
    }
}