using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayofweek;
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    dayofweek = "Monday";
                    break;
                case 2:
                    dayofweek = "Tuesday";
                    break;
                case 3:
                    dayofweek = "Wednesday";
                    break;
                case 4:
                    dayofweek = "Thursday";
                    break;
                case 5:
                    dayofweek = "Friday";
                    break;
                case 6:
                    dayofweek = "Saturday";
                    break;
                case 7:
                    dayofweek = "Sunday";
                    break;
                default:
                    dayofweek = null;
                    break;
            }
            if (string.IsNullOrEmpty(dayofweek))
            {
                Console.WriteLine("Invalid input.");
            }
            else Console.WriteLine($"The day number {day} of the week is: {dayofweek}");

            Console.ReadKey();
        }
    }
}