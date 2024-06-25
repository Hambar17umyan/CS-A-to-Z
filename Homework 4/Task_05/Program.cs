using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countries = "Armenia, Georgia, Iran, Saudi Arabia, United States of America, Israel, Palestine";
            Console.WriteLine(countries);

            countries = countries.Replace(", ", ",");

            string[] arr = new string[10];
            arr = countries.Split(',');
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            Console.Read();
        }
    }
}