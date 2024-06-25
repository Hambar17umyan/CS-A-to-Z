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

namespace Task_01
{
    internal class Program
    {
        public static void inparr(ref int[] arr)
        {
            arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        }

        static void Main(string[] args)
        {
            int n = 10;
            int max;
            try
            {
                int[] arr = new int[n];
                inparr(ref arr);
                max = arr[0];
                for (int i = 1; i < n; i++)
                {
                    if (max < arr[i])
                        max = arr[i];
                }
                Console.WriteLine(max);
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