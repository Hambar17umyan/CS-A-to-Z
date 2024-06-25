using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 6:
            Seasons Enum:
            Create an enum for seasons (e.g., Spring, Summer, Autumn, Winter). Write a program that displays the current season based on the month.
			*/
            DateTime CurrentDate = DateTime.Now;
            int mn = CurrentDate.Month;
            Season CurrentSeason = new Season();
            Month CurrentMonth = (Month)mn;

            if (CurrentMonth <= Month.February || CurrentMonth == Month.December)
                CurrentSeason = Season.Winter;
            else if (CurrentMonth <= Month.May)
                CurrentSeason = Season.Spring;
            else if (CurrentMonth <= Month.August)
                CurrentSeason = Season.Summer;
            else CurrentSeason = Season.Fall;

            Console.WriteLine($"The current month is {CurrentMonth}. That means that now is {CurrentSeason}");

        }
    }
    enum Season
    {
        None,
        Winter,
        Spring,
        Summer,
        Fall
    }
    enum Month
    {
        None,
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}