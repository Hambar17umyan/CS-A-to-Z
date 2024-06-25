using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "TTT";
            string str2 = "TTT";
            string str3 = new string('T', 3);
            Console.WriteLine($"str1: {str1}\nstr2: {str2}\nstr3: {str3}");
            Console.WriteLine($"The references of str1 and str2 are equal: {ReferenceEquals(str1, str2)}");
            Console.WriteLine($"The references of str1 and str3 are equal: {ReferenceEquals(str1, str3)}");

            Console.Read();
        }
    }
}