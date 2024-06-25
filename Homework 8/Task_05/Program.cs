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
            /*
			Task 5:
            Weekdays Enum:
            Define an enum for weekdays (e.g., Monday, Tuesday, …). Use it to determine whether today is a working day or a weekend day.
            */
            Console.WriteLine("Which day of week is today? Type 1-7!");
            byte day = byte.Parse(Console.ReadLine());
            if (day > 7 || day < 1)
                Console.WriteLine("Invalid input. Try again!");
            else
            {
                week weekday = (week)day;
                string output = (weekday > week.Friday) ? "weekend. Enjoy your day!" : $"weekday. You will need to wait for {week.Saturday - weekday} days to take a rest";
                Console.WriteLine($"Today is {weekday}. That means that today is a {output}");
            }
        }
    }
    enum week
    {
        None,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}