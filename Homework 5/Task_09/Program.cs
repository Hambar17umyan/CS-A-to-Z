using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string level;
            level = Console.ReadLine();
            switch (level)
            {
                case "1":
                    Console.WriteLine("Level 1: Beginner");
                    break;
                case "2":
                    Console.WriteLine("Level 2: Intermediate");
                    break;
                case "3":
                    Console.WriteLine("Level 3: Advanced");
                    break;
                default:
                    Console.WriteLine("Invalid level");
                    break;
            }

            Console.ReadKey();
        }
    }
}