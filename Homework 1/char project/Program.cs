using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace char_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c1 = 'a';
            c1 = 'F';
            //English letters can be assigned to char

            char c2 = '~';
            c2 = '!';
            c2 = ',';
            c2 = '"';
            //different symbols can be assigned to char

            char c3 = '+';
            c3 = '-';
            c3 = '*';
            c3 = '/';
            c3 = '=';
            //different mathematical symbols can be assigned to char

            char c4 = '\n'; //a new line symbol can be assigned to char

            char c;
            for(int i = 1; i<=126; i++)
            {
                c = (char)i;
                Console.Write(c);
                Console.Write(c4);
            }
            Console.ReadKey();
        }
    }
}
