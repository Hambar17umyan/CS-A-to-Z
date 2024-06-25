using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 18:
            Flags for UI Elements:
            Define an enum for UI elements (e.g., Button, TextBox, Checkbox).
            Use bitwise operations to manage which UI elements are visible or enabled.
			*/
            Vision elements = new Vision();
            while (true)
            {
                Console.WriteLine("You can change the visibility of the following UI elements. Just write the number of element:\n1.Scene 1\n2.Scene 2\n3.Menu button\n4.Retry button\n5.Feedback Area\n6.Pause button.");
                Console.WriteLine();
                Console.WriteLine("Here are the settings that are currently visible: " + elements);
                int input;
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input > 6 || input < 1)
                        Console.WriteLine("Invalid input. Try again!");
                    else
                    {
                        elements ^= (Vision)(1 << (input - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
            }
        }
    }
    enum Vision
    {
        None,
        Scene1,
        Scene2,
        MenuButton = 4,
        RetryButton = 8,
        FeedbackArea = 16,
        PauseButton = 32
    }
}