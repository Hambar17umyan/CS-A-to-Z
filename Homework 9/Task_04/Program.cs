using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
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
			Task 4:
            Copy Elements to Another Array:
            Copy the elements of one array into another array.
            Test Data: Input 3 elements in the array: 15, 10, 12.
            Expected Output:
            Elements stored in the first array: 15 10 12.
            Elements copied into the second array: 15 10 12.
			*/
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = ArrayInput(n);
                int[] CoppiedArray = new int[n];
                Array.Copy(arr, CoppiedArray, n);
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}