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
            /*
			Task 1:
            Print Array Elements:
            Write a C# program that stores elements in an array and prints them.
            Test Data: Input 10 elements in the array: 1, 1, 2, 3, 4, 5, 6, 7, 8, 9.
            Expected Output: Elements in the array are: 1 1 2 3 4 5 6 7 8 9.
			*/
            Console.WriteLine("How many elements does the array have?");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[] arr = new int[n];
                Console.WriteLine("Enter each element in a separate line!");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.WriteLine($"Invalid input. Type the {i + 1}th number again!");
                        i--;
                        continue;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i].ToString() + ' ');
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}