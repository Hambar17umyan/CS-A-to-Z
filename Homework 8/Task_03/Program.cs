using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 3:
            Custom Enum Properties:
            Extend the language enum by adding properties like the official name of the language or its ISO code.
			*/
            for (int i = 0; i <= 5; i++)
            {
                language lang = (language)i;
                Console.WriteLine($"The official name of {lang} is {OfficialName(lang)}");
            }
        }

        static string OfficialName(language lang)
        {
            switch (lang)
            {
                case language.English:
                    return "English";
                case language.French:
                    return "Français";
                case language.Spanish:
                    return "Español";
                case language.Russian:
                    return "Русский";
                case language.Armenian:
                    return "հայերեն";
            }
            return "<Not defined>";
        }
    }


    [Flags]
    enum language
    {
        None,
        English,
        French,
        Spanish,
        Armenian,
        Russian
    }
}