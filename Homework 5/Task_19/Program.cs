using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string c;
            c = Console.ReadLine();
            if (c.Length > 1)
            {
                Console.WriteLine("Invalid input");
            }
            else if (c[0].ToString().ToLower()[0] >= 'a' && c[0].ToString().ToLower()[0] <= 'z')
            {
                switch (c)
                {
                    case "a":
                        Console.WriteLine("vowel");
                        break;
                    case "e":
                        Console.WriteLine("vowel");
                        break;
                    case "i":
                        Console.WriteLine("vowel");
                        break;
                    case "o":
                        Console.WriteLine("vowel");
                        break;
                    case "u":
                        Console.WriteLine("vowel");
                        break;
                    default:
                        Console.WriteLine("consonant");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadKey();
        }
    }
}