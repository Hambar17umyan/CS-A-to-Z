using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            int hash_a = a.GetHashCode();
            int hash_b = b.GetHashCode();
            int hash_c = c.GetHashCode();

            Console.WriteLine($"Here are the hash codes of your inputs");
            Console.WriteLine($"String 1){a}: {hash_a}");
            Console.WriteLine($"String 2){b}: {hash_b}");
            Console.WriteLine($"String 3){c}: {hash_c}");

            Console.WriteLine("Let us compare them!");
            Console.WriteLine($"String1 = String2: {hash_a == hash_b}");
            Console.WriteLine($"String1 = String3: {hash_a == hash_c}");
            Console.WriteLine($"String2 = String3: {hash_b == hash_c}");


            Console.Read();
        }
    }
}

/*
 * 
 * -838223905
-842352673
-842352673


 * */