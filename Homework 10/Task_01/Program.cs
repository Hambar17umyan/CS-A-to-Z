namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the array in a single line");
            string input = Console.ReadLine();
            double[] arr = Array.ConvertAll(input.Trim().Split(' '), Convert.ToDouble);
            double res;
            FindMinimumWithOut(arr, out res);
            Console.WriteLine(res);
        }

        static void FindMinimumWithOut(double[] arr, out double res)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[0])
                    arr[0] = arr[i];
            }
            res = arr[0];
        }
    }
}
