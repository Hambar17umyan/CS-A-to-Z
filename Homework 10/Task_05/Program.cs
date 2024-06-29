using System.Text;

namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Reverse(ref s);
            Console.WriteLine(s);
        }

        static void Reverse(ref string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                sb.Append(input[i]);
            }
            input = sb.ToString();
        }
    }
}
