using System.Collections.Specialized;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the array in a single line");

            string input = Console.ReadLine();
            double[] arr = new double[0];
            try
            {
                arr = Array.ConvertAll(input.Trim().Split(' '), Convert.ToDouble);
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }

            double res;
            int count = FindMaximumWithOut(arr, out res);
            Console.WriteLine($"{count} x {res}");
        }

        static int FindMaximumWithOut(double[] arr, out double res)
        {
            int count = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[0])
                {
                    arr[0] = arr[i];
                    count = 1;
                }
                else if (arr[i] == arr[0])
                    count++;
            }
            res = arr[0];
            return count;
        }
    }
}
