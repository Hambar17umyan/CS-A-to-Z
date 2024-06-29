namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array in a single line");
            int[] arr;
            try
            {
                arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            }
            catch
            {
                Console.WriteLine("Invalid input");
                return;
            }

            ModifyArrayWithRef(arr);
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
        }

        static void ModifyArrayWithRef(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }
        }
    }
}
