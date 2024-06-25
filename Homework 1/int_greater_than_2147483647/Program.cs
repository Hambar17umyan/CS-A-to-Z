using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_greater_than_2147483647
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 10000000000; //should give an error, inasmuch as it contains a value of int64 assigned to int32 data type
            Console.WriteLine(a);
            Console.ReadKey();

            int b;
            b = -10000000000;//should give an error, inasmuch as it contains a value of int64 assigned to int32 data type
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
