using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 10)
            {
                Console.WriteLine("The number is greater than 10.");
            }

            Console.ReadKey();
        }
    }
}