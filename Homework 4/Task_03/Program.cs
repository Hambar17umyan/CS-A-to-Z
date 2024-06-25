using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task_03
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int age;
            string firstname, middlename, lastname, profession;

            Console.Write("Enter your first name: ");
            firstname = Console.ReadLine();

            Console.Write("Enter your middle name: ");
            middlename = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastname = Console.ReadLine();

            Console.Write("Enter your profession: ");
            profession = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"So you are {firstname} {middlename} {lastname}. You are {age} years old and you work as a {profession}.");

            Console.Read();
        }
    }
}