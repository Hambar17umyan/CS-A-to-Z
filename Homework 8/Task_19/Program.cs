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
            /*
			Task 19:
            Binary Representation of Enum Values:
            Convert an integer value (e.g., 37) to an enum type using casting.
            Display the binary representation of the resulting enum value.
			*/
            ProgLanguages progLanguages = new ProgLanguages();
            int number = 2 | 4 | 1;
            progLanguages = (ProgLanguages)number;
            Console.WriteLine(progLanguages);
            Console.WriteLine(Convert.ToString((int)progLanguages, 2).PadLeft(5, '0'));
        }
    }

    [Flags]
    enum ProgLanguages
    {
        None,
        CSharp,
        Java,
        CPlusPlus = 4,
        JavaScript = 8,
        Python = 16
    }
}
