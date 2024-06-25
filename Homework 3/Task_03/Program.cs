using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = "2007";
            int intnum = Convert.ToInt32(number);
            Console.WriteLine("The string variable: " + number);
            Console.WriteLine("The int variable: " + intnum);

            Console.ReadKey();
        }
    }
}