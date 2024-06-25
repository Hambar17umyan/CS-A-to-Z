using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a console name!");
            string title = Console.ReadLine();
            Console.Title = title;

            Console.ReadKey();
        }
    }
}