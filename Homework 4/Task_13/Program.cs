using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";
            Console.WriteLine($"str1: {str1}\nstr2: {str2}\nstr3: {str3}");
            Console.WriteLine($"The contents of str1 and str2 are equal: {str1 == str2}");
            Console.WriteLine($"The contents of str1 and str3 are equal: {str1 == str3}");

            Console.Read();
        }
    }
}