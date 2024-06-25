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

namespace Task_04
{
    internal class Program
    {
        public static void inparr(ref int[] arr)
        {
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        }

        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[50];
                inparr(ref arr);
                decimal res = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    res += arr[i];
                }
                res /= 50;
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