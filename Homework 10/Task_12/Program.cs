namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            double avarage;
            int max, sum;
            CalculateStatistics(arr, out avarage, out max, out sum);
            Console.WriteLine($"Sum: {sum}\nAvarage: {avarage}\nMax: {max}");
        }

        static void CalculateStatistics(int[] arr, out double avarage, out int max, out int sum)
        {
            sum = 0;
            max = arr[0];
            foreach (int i in arr)
            {
                sum += i;
                max = Math.Max(max, i);
            }
            avarage = (double)sum / arr.Length;
        }
    }
}
