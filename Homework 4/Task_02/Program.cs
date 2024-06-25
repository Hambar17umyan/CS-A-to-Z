using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string str1;
            string str2;
            string str3;
            string str4;
            string str5;
            str1 = "Hello";
            str2 = "my";
            str3 = "name";
            str4 = "is";
            str5 = "Sergey.";
            string space = " ";
            string res = string.Concat(str1, space, str2, space, str3, space, str4, space, str5);

            Console.Read();
        }
    }
}