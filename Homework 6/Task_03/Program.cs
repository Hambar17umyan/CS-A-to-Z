using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            string line = new string('-', 34);
            Console.Write("x ");
            Console.Write('|');
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                Console.Write(' ');
                Console.Write('|');
            }
            Console.Write('\n');
            Console.WriteLine(line);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i);
                if (i != 10)
                {
                    Console.Write(' ');
                }
                Console.Write('|');
                for (int j = 1; j <= 9; j++)
                {
                    int a = j * i;
                    Console.Write(a);
                    if (a < 10)
                        Console.Write(' ');
                    Console.Write('|');
                }

                int a1 = 10 * i;
                Console.Write(a1);
                if (a1 < 100)
                    Console.Write(' ');
                Console.Write('|');
                Console.Write('\n');
                Console.WriteLine(line);
            }
        }
    }
}