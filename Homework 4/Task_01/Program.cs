using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_01
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string s = "Hello beautiful world. It's Sergey coding!";
            Console.WriteLine(s);
            Console.WriteLine($"The length of the string is: {s.Length}");

            string up = s.ToUpper();
            Console.WriteLine($"Uppercase: {up}");

            string low = s.ToLower();
            Console.WriteLine($"Lowercase: {low}");

            int index = s.IndexOf("world");
            Console.WriteLine($"The first substring \"world\" was found at the index of {index}");

            s = s.Substring(index, "world".Length);
            Console.WriteLine(s);

            Console.Read();
        }
    }
}