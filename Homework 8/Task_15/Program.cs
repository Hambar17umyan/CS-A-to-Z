using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 15:
            Toggle a Flag On/Off:
            Define an enum for game settings (e.g., SoundOn, MusicOn, FullScreen).
            Toggle the SoundOn setting using bitwise XOR (^)
			*/
            Settings GameSettings = new Settings();
            while (true)
            {
                Console.WriteLine("You can toggle the following settings. Just write the number of setting:\n1.Sound\n2.Joystick\n3.Full screen\n4.3D mode\n5.Music.");
                Console.WriteLine();
                Console.WriteLine("Here are the settings that are currently on: " + GameSettings);
                int input;
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input > 5 || input < 1)
                        Console.WriteLine("Invalid input. Try again!");
                    else
                    {
                        GameSettings ^= (Settings)(1 << (input - 1));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
            }
        }
        [Flags]
        enum Settings
        {
            None = 0,
            SoundOn = 1,
            Joystick = 2,
            FullScreen = 4,
            _3DMode = 8,
            MusicOn = 16
        }
    }
}