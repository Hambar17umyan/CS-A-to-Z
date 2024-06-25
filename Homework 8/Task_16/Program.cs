using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 16:
            Weekend Days Combination:
            Extend the days-of-the-week enum to include a Weekend combination (Saturday and Sunday).
            Calculate the weekend days using bitwise OR (|).
			*/
            WeekDay weekend = WeekDay.Saturday | WeekDay.Sunday;
            Console.WriteLine("Here are the weekend days: " + weekend);
        }
    }
    [Flags]
    enum WeekDay
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64
    }
}
