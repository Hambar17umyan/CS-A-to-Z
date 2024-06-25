using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double d;
            d = 17.5;
            i = (int)d;
            Console.WriteLine($"The int variable: {i}\nThe double variable: {d}");

            Console.ReadKey();
        }
    }
}