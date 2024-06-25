using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 2:
            Language Translation Enum:
            Create an enum for languages (e.g., English, Spanish, French). Implement a switch case that translates a given word from English to the selected language
			*/
            while (true)
            {
                Console.WriteLine("I will translate the word dot NET to some registered language. Type the langauge!");
                language trlang = new language();
                string s = Console.ReadLine();
                switch (s)
                {
                    case "English":
                        trlang = language.English;
                        break;
                    case "Spanish":
                        trlang = language.Spanish;
                        break;
                    case "French":
                        trlang = language.French;
                        break;
                }
                if (trlang == language.none)
                {
                    Console.WriteLine("Please try again!");
                    continue;
                }
                else if (trlang == language.French)
                {
                    Console.WriteLine("point NET");
                }
                else if (trlang == language.Spanish)
                {
                    Console.WriteLine("punto NET");
                }
                else
                {
                    Console.WriteLine("dot NET");
                }
                break;

            }
        }

        enum language
        {
            none,
            English,
            Spanish,
            French
        }
    }
}