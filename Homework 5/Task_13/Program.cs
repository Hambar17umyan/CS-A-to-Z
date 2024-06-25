using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade;
            try
            {
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade == 20 || grade == 19 || grade == 18)
                {
                    Console.WriteLine("Excellent");
                }
                else if (grade == 17 || grade == 16 || grade == 15)
                {
                    Console.WriteLine("Good");
                }
                else if (grade == 14 || grade == 13 || grade == 12 || grade == 11)
                {
                    Console.WriteLine("Avarage");
                }
                else if (grade >= 8)
                {
                    Console.WriteLine("Poor");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }

            Console.ReadKey();
        }
    }
}