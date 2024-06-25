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

namespace Task_06
{
    internal class Program
    {
        public static long pow(long a, long p)
        {
            long res = 1;
            if (a == 0)
                return 0;
            for (long i = 0; i < p; i++)
            {
                if (long.MaxValue / a < res)
                {
                    return -1;
                }
                res *= a;
            }
            return res;
        }

        static void Main(string[] args)
        {
            try
            {
                string s = Console.ReadLine();
                long n = Convert.ToInt64(s);
                long res = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    long p = pow((long)(s[i] - '0'), s.Length);
                    if (p == -1)
                    {
                        Console.WriteLine("The number you have entered is too big!");
                        return;
                    }
                    res += p;
                }
                if (res == n)
                {
                    Console.WriteLine("Is an Armstrong number!");
                }
                else
                    Console.WriteLine("Is not an Armstrong number!");
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