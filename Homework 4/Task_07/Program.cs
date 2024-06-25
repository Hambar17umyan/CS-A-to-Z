using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "     Hello, world!      ";
            str = str.Trim();
            Console.WriteLine(str);

            Console.Read();
        }
    }
}