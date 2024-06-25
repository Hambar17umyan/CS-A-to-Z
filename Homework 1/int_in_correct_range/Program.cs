using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int_in_correct_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = (1 << 15); // the maximal value of int is 2^32. Therefore 2^15 will stand in the range supported by int32
            Console.WriteLine("All is correst. Here is n: " + n + '\n');

            n = -(1 << 17);// the minimal value of int is -2^32. Therefore -2^17 will stand in the range supported by int32
            Console.WriteLine("All is correct. Here is n: " + n + '\n');

            Console.ReadKey();
        }
    }
}
