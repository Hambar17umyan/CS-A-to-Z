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

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int res = 0;
                string s = Console.ReadLine();
                int n = Convert.ToInt32(s);
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '2':
                        case '4':
                        case '6':
                        case '8':
                            res += (s[i] - '0');
                            break;
                    }
                }
                Console.WriteLine(res);
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