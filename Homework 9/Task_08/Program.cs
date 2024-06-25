using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    internal class Program
    {
        static int[] ArrayInput()
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        }
        static void Main(string[] args)
        {
            /*
            Task 8:
            Frequency of Each Element:
            Count the frequency of each element in an array.
            Test Data: Input 3 elements in the array: 25, 12, 43.
            Expected Output:
            Frequency of all elements of the array:
            25 occurs 1 time.
            12 occurs 1 time.
            43 occurs 1 time.
            */
            try
            {
                int[] arr = ArrayInput();
                Array.Sort(arr);
                int count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    count++;
                    if (i != arr.Length - 1 && arr[i] == arr[i + 1])
                    {
                        continue;
                    }
                    Console.WriteLine($"{arr[i]} occurs {count} times!");
                    count = 0;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}