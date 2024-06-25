using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
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
			Task 2:
            Reverse Order:
            Read n values in an array and display them in reverse order.
            Test Data: Input the number of elements to store in the array: 3.
            Input 3 numbers: 2, 5, 7.
            Expected Output: The values stored in the array are: 2 5 7. The values in reverse order are: 7 5 2.
			*/
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = ArrayInput(n);
                Array.Reverse(arr);
                foreach (int i in arr)
                    Console.Write(i.ToString() + ' ');
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}