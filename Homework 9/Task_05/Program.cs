using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
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
			Task 5:
            Count Duplicate Elements:
            Count the number of duplicate elements in an array.
            Test Data: Input 3 elements in the array: 5, 1, 1.
            Expected Output: Total number of duplicate elements found in the array is: 1.
			*/
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = ArrayInput(n);
                int dubl = 0;
                foreach (int i in arr)
                {
                    foreach (int j in arr)
                    {
                        if (i == j)
                            dubl++;
                    }
                }
                dubl -= n;

                Console.WriteLine(dubl / 2);
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}