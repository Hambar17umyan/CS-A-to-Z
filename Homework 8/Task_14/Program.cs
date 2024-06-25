using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 14:
            Check If a Flag Is Set:
            Create an enum for font styles (e.g., Bold, Italic, Underline).
            Check if a given font style (e.g., Bold) is set using bitwise AND (&).
			*/
            Style font = Style.bold | Style.italic | Style.underline;
            for (int i = 1; i < 9; i <<= 1)
            {
                if (font.HasFlag((Style)i))
                    Console.WriteLine("The text is " + (Style)i);
            }
        }
    }

    [Flags]
    enum Style
    {
        bold = 1,
        italic = 2,
        underline = 4,
        strikethrough = 8
    }
}