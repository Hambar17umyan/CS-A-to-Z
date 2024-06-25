using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 8:
            Traffic Light Enum:
            Implement an enum for traffic light colors (e.g., Red, Yellow, Green). Simulate a traffic light sequence using a loop.
			*/
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");

                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 10; i > 0; i--)
                {
                    Console.Write($"It's {TrafficLight.Red}. Wait {i} seconds! \r");
                    Thread.Sleep(1000);
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"It's {TrafficLight.Yellow}. Be carefull!");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();


                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                for (int i = 10; i > 0; i--)
                {
                    Console.Write($"It's {TrafficLight.Green}. You are free to go for {i} seconds! \r");
                    Thread.Sleep(1000);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("■■■■\n■■■■\n■■■■\n■■■■\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"It's {TrafficLight.Yellow}. Be carefull!");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

    }
    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }
}