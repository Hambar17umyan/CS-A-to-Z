using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s_empt = string.Empty;
            string s = "Hi, I am very happy!";
            string space = " ";

            Console.WriteLine($"The string \"{s_empt}\" is Null or Empty: {string.IsNullOrEmpty(s_empt)}");
            Console.WriteLine($"The string \"{s}\" is Null or Empty: {string.IsNullOrEmpty(s)}");
            Console.WriteLine($"The string \"{space}\" is Null or Empty: {string.IsNullOrEmpty(space)}");

            Console.WriteLine($"The string \"{s_empt}\" is Null or Whitespace: {string.IsNullOrWhiteSpace(s_empt)}");
            Console.WriteLine($"The string \"{s}\" is Null or Whitespace: {string.IsNullOrWhiteSpace(s)}");
            Console.WriteLine($"The string \"{space}\" is Null or Whitespace: {string.IsNullOrWhiteSpace(space)}");

            Console.Read();
        }
    }
}