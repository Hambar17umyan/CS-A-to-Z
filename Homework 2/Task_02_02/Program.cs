using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your password!");
            string pass = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Password is saved!");

            Console.ReadKey();
        }
    }
}