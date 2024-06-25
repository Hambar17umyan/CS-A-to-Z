using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 9:
            File Extensions Enum:
            Create an enum for common file extensions (e.g., .txt, .jpg, .pdf). Use it to validate file uploads.
			*/
            Console.Write("Enter the file name without extension:");
            string name = Console.ReadLine();
            Console.WriteLine("Now enter the extension number alone.\nHere are they:\n1.txt\n2.jpg\n3.pdf\n4.cs\n5.snippet.");
            int ex = int.Parse(Console.ReadLine());
            if (ex > 5 || ex < 1)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                Console.WriteLine("So your choice is " + (extension)ex);
                Console.WriteLine();
                Console.WriteLine($"The file name is: {name}.{(extension)ex}");
            }
        }
    }

    enum extension
    {
        None,
        txt,
        jpg,
        pdf,
        cs,
        snippet
    }
}