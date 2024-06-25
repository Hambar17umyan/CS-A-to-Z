using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02_01
{
    internal class Program
    {
        static void bgcol(int k)
        {
            if (k == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (k == 2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
        }
        static void fgcol(int k)
        {
            if (k == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (k == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        static void Main(string[] args)
        {
            int k = 1;
            int l = 2;
            while (true)
            {
                if (k == 4)
                {
                    k = 1;
                    Console.WriteLine();
                }

                if (l == 4)
                    l = 1;

                Console.Clear();
                Console.ResetColor();
                bgcol(k);
                fgcol(l);
                Console.WriteLine("The code is crazy.");
                Thread.Sleep(200);
                k++;
                l++;
            }
        }
    }
}