namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array in a single line!");
            int[] arr;
            try
            {
                arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            }
            catch
            {
                Console.WriteLine("Invalid input. Try again!");
                return;
            }
            double res;
            CalculateAverageWithOut(arr, out res);
            Console.WriteLine(res);
        }

        static void CalculateAverageWithOut(int[] arr, out double res)
        {
            res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }
            res /= arr.Length;
        }
    }
}
