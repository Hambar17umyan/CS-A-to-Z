using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int res = 0;
            if (number == null)
            {
                Console.WriteLine("You have entered a null number!");
                return;
            }
            if (number[0] == '0')
            {
                Console.WriteLine("A number cannot start with 0.");
                return;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    res += (number[i] - '0');
                }
                else
                {
                    Console.WriteLine("You have entered another data type. Please retry with natural number.");
                    return;
                }
            }
            Console.WriteLine(res);
        }
    }
}