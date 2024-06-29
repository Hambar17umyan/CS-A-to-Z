namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out var value))
            {
                int[] arr = FirstPrimeNumbers(value);
                foreach (int i in arr)
                {
                    Console.Write(i.ToString() + ' ');
                }
            }
            else Console.WriteLine("Wrong input!");
        }

        static bool isPrime(int a)
        {
            if (a == 2)
                return true;
            int m = (int)Math.Sqrt(a);
            for (int i = 2; i <= m; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

        static int[] FirstPrimeNumbers(int n)
        {
            int[] res = new int[n];
            int j = 0;
            int i = 2;
            while (j < n)
            {
                if (isPrime(i))
                {
                    res[j] = i;
                    j++;
                }
                i++;
            }
            return res;
        }
    }
}
