using System.ComponentModel;
using System.Net.Sockets;

namespace Task_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        Address Address;

        public Person(string firstName, string lastName, int age, Address address)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
            Address = address; 
        }
    }

    struct Address
    {
        public string Street { get; }
        public string City { get; }
        public string PostalCode { get; }

        public Address(string street, string city, string postalCode)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
        }
    }
}
