using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let us play Rock, Paper, Scissors!");
            int score1, score2;
            string input;
            int rand_gen;
            score1 = score2 = 0;
            Random rnd = new Random();
            string gen;
            while (true)
            {
                Console.WriteLine("Type \'R\' or \'r\' for Rock!");
                Console.WriteLine("Type \'P\' or \'p\' for Paper!");
                Console.WriteLine("Type \'S\' or \'s\' for Scissors!");
                Console.WriteLine("Type over for the program to stop!");

                input = Console.ReadLine();
                rand_gen = rnd.Next(1, 3);

                if (input == "over")
                {
                    Console.WriteLine($"Game over! The score:\nYou: {score1}\nMe: {score2}");
                    break;
                }
                if (rand_gen == 1)
                {
                    gen = "Rock";
                    if (input == "r" || input == "R")
                    {
                        Console.WriteLine(gen);
                        Console.WriteLine($"Tie. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else if (input == "p" || input == "P")
                    {
                        score1++;
                        Console.WriteLine(gen);
                        Console.WriteLine($"You win. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else if (input == "s" || input == "S")
                    {
                        score2++;
                        Console.WriteLine(gen);
                        Console.WriteLine($"I win. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again!");
                        continue;
                    }
                }
                else if (rand_gen == 2)
                {
                    gen = "Paper";

                    if (input == "r" || input == "R")
                    {
                        score2++;
                        Console.WriteLine(gen);
                        Console.WriteLine($"I win. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else if (input == "p" || input == "P")
                    {
                        Console.WriteLine(gen);
                        Console.WriteLine($"Tie. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else if (input == "s" || input == "S")
                    {
                        score1++;
                        Console.WriteLine(gen);
                        Console.WriteLine($"You win. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again!");
                        continue;
                    }
                }
                else
                {
                    gen = "Scissors";
                    if (input == "r" || input == "R")
                    {
                        score2++;
                        Console.WriteLine(gen);
                        Console.WriteLine($"I win. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else if (input == "p" || input == "P")
                    {
                        score1++;
                        Console.WriteLine(gen);
                        Console.WriteLine($"You win. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else if (input == "s" || input == "S")
                    {
                        Console.WriteLine(gen);
                        Console.WriteLine($"Tie. The ongoing score:\nYou: {score1}\nMe: {score2}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again!");
                        continue;
                    }
                }
            }
        }
    }
}