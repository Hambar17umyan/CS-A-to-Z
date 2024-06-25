using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            int score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                grade = 'A';
            }
            else
            {
                if (score >= 80)
                {
                    grade = 'B';
                }
                else
                {
                    if (score >= 70)
                    {
                        grade = 'C';
                    }
                    else
                    {
                        if (score >= 60)
                        {
                            grade = 'D';
                        }
                        else
                        {
                            grade = 'F';
                        }
                    }
                }
            }

            Console.WriteLine("According to your score your grade is: " + grade);

            Console.ReadKey();
        }
    }
}