using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            switch (command)
            {
                case "start":
                    Console.WriteLine("The program is now started!");
                    break;
                case "stop":
                    Console.WriteLine("The program is now stopped!");
                    break;
                case "pause":
                    Console.WriteLine("The program is now paused!");
                    break;
                case "resume":
                    Console.WriteLine("The program is now resumed!");
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;

            }

            Console.ReadKey();
        }
    }
}