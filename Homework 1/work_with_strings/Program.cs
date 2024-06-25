using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, age;
            Console.Write("Enter your name: ");
            name = Console.ReadLine(); // the program reads the name of the user from the console

            Console.Write("Enter your surname: ");
            surname = Console.ReadLine();// the program reads the surname of the user from the console

            Console.Write("Enter your age: ");
            age = Console.ReadLine();
            /*
            The program can also store the data from console in string variable, 
            which is considered as a different data type like int from 
            the first glance. In fact, the data given by the user is string, 
            inasmush as we've used the method ReadLine() without further convertations.
            */

            //So to be sure that we've done everything right, let us print the results on the screen.
            Console.WriteLine("Your data\n" + $"Name: {name}\nSurname:{surname}\nAge: {age}");

            Console.ReadKey();

        }
    }
}
