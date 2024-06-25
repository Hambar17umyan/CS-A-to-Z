using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b;//bool is a data type that can contain either 1 or 0
            Console.Write("Enter your age: ");
            int age = System.Convert.ToInt32(Console.ReadLine());
            b = (age >= 18);
            if (b)
                Console.WriteLine("Is an adult.");
            else
                Console.WriteLine("Is not an adult.");

            short s;//short is a data type that can contain numbers in range [-2^16, 2^16)
            s = (1 << 10);


            long l;//long is a data type that can contain numbers in range [-2^64, 2^64)
            l = -(1 << 48);

            Console.ReadKey();
        }
    }
}
