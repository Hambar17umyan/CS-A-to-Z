using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        public static void inparr(ref int[] arr)
        {
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            if (s1.Length != 1)
            {
                Console.WriteLine("Please type a single character!");
            }
            else
            {
                char c = s1[0];
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (c == s[i])
                        count++;
                }
                Console.WriteLine($"I found {count} occurances of the character {c} in the text."); ;
            }
        }

    }
}