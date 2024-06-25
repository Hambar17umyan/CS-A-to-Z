using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace different_data_type_assigned_to_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter your name: ");
            a = Console.ReadLine(); //string data type is assigned to an integer

            bool b = true;
            a = b; //bool data type is assigned to an integer

            sbyte c = 25;
            a = c;
            /*
            different(sbyte) data type is assigned to an integer, but the expression is valid, inasmuch as the range of integer contains the sbyte's range too. 
            More specifically:
                The range of integer is [-2147483648, 2147483647]
                The range of sbyte is [-128, 127]
            */

            //The same explanation works here with short
            short d = 109;
            a = d;

        }
    }
}
