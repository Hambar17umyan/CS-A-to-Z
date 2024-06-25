using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
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
			Task 6:
            Print Unique Elements:
            Print all unique elements in an array.
            Test Data: Input 3 elements in the array: 1, 5, 1.
            Expected Output: The unique elements found in the array are: 5.
            */
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr = ArrayInput(n);
                foreach (int i in arr)
                {
                    int count = 0;
                    foreach (int j in arr)
                    {
                        if (i == j)
                            count++;
                    }
                    if (count == 1)
                    {
                        Console.Write(i);
                        Console.Write(' ');
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}