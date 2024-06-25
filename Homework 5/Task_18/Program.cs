using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    Console.WriteLine("Option 1 selected");
                    break;
                case "2":
                    Console.WriteLine("Option 2 selected");
                    break;
                case "3":
                    Console.WriteLine("Option 3 selected");
                    break;
                case "4":
                    Console.WriteLine("Option 4 selected");
                    break;
                case "5":
                    Console.WriteLine("Option 5 selected");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.ReadKey();
        }
    }
}