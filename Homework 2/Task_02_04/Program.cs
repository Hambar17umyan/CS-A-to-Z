using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a confirmation message(ok)");
            string mes = Console.ReadLine();
            if (mes == "ok")
            {
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Ok! I won't beep.");
            }

            Console.ReadKey();
        }
    }
}