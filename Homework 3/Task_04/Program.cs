using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "2007";
            int i = int.Parse(number);
            Console.WriteLine(i);

            string newstring = Console.ReadLine();
            bool success = int.TryParse(newstring, out i);
            if (success)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("The string was not numeric.");
            }

            Console.ReadKey();
        }
    }
}