using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "I love programming in Java";
            str = str.Replace("Java", "C#");
            Console.WriteLine(str);

            Console.Read();
        }
    }
}