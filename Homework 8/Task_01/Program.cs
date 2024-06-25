using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 1:
            Declare and Assign Enum Constants:
            Declare an enum representing different weather conditions (e.g., Sunny, Cloudy, Rainy). Assign one of its constants to a variable and print a message based on the weather.
			*/
            weather now = weather.cloudy;
            Console.WriteLine($"The weather is currently {now}.");
            if (now.ToString() == "cloudy")
            {
                Console.WriteLine($"It would be the best to take an umbrella with you");
            }
        }
    }

    [Flags]
    enum weather
    {
        sunny,
        cloudy,
        rainy
    }
}