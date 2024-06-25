using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static int[] ArrayInput(int n)
        {
            return Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
        }
        static void Main(string[] args)
        {
            /*
			Task 3:
            Sum of Array Elements:
            Find the sum of all elements in an array.
            Test Data: Input 3 elements in the array: 2, 5, 8.
            Expected Output: Sum of all elements stored in the array is: 15.
			*/
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = ArrayInput(n);
                int sum = 0;
                foreach (int i in arr)
                {
                    sum += i;
                }
                Console.WriteLine(sum);
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}