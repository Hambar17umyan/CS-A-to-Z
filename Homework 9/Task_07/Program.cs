using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
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
            Task 7:
            Merge Sorted Arrays:
            Merge two arrays of the same size sorted in ascending order.
            Test Data:
            First array: 1, 2, 3.
            Second array: 1, 2, 3.
            Expected Output: The merged array in ascending order: 1 1 2 2 3 3.
            */
            try
            {
                Console.WriteLine("Enter the first array!");
                int[] arr1 = ArrayInput();
                Console.WriteLine("Enter the second array!");
                int[] arr2 = ArrayInput();
                arr1 = arr1.Concat(arr2).ToArray();
                Array.Sort(arr1);
                foreach (int i in arr1)
                {
                    Console.Write(i);
                    Console.Write(' ');
                }
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}