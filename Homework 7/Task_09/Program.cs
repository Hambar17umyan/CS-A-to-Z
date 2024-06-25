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

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string?[] arr;
            arr = s.Trim().Split(' ', '\t', '\n');
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != string.Empty)
                {
                    res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}