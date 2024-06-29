using System.Diagnostics.Contracts;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st string:");
            string a = Console.ReadLine();

            Console.WriteLine("2nd string:");
            string b = Console.ReadLine();

            Console.WriteLine(CheckIfAnagrams(a, b) ? "Are anagrams" : "Are not anagrams");
        }

        static bool CheckIfAnagrams(string a, string b)
        {
            char[] ca, cb;
            ca = a.ToCharArray();
            cb = b.ToCharArray();
            Array.Sort(ca);
            Array.Sort(cb);
            if (ca.Length != cb.Length)
                return false;
            for (int i = 0; i < ca.Length; i++)
            {
                if (ca[i] != cb[i])
                    return false;
            }
            return true;
        }
    }
}
