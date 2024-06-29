namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] arr =SplitStringIntoWords(s);
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }
        }

        static string[] SplitStringIntoWords(string s)
        {
            return s.Trim().Split(' ');
        }
    }
}
