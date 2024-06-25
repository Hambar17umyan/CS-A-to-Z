using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b;
            string menuOption;
            menuOption = Console.ReadLine();
            if (menuOption == "1")
            {
                b = true;
            }
            else if (menuOption == "2")
            {
                b = true;
            }
            else if (menuOption == "3")
            {
                b = true;
            }
            else
            {
                b = false;
                Console.WriteLine("Invalid option!");
            }
            if (b)
            {
                switch (menuOption)
                {
                    case "1":
                        Console.WriteLine("Start game!");
                        break;
                    case "2":
                        Console.WriteLine("Load game!");
                        break;
                    case "3":
                        Console.WriteLine("Exit!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}