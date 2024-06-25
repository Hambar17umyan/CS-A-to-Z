using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringComparison comparison;
            string a, b;
            a = "Serg";
            b = "SERG";

            Console.WriteLine($"a: {a}\nb: {b}");

            Console.WriteLine($"a is equal to b: {Equals(a, b)}");
            comparison = StringComparison.OrdinalIgnoreCase;
            Console.WriteLine($"a is equal to b with comparison \"OrdinalIgnoreCase\": {a.Equals(b, comparison)}");

            comparison = StringComparison.InvariantCultureIgnoreCase;
            Console.WriteLine($"a is equal to b with comparison \"InvariantCultureIgnoreCase\": {a.Equals(b, comparison)}");

            comparison = StringComparison.InvariantCulture;
            Console.WriteLine($"a is equal to b with comparison \"InvariantCulture\": {a.Equals(b, comparison)}");


            Console.Read();
        }
    }
}