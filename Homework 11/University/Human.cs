using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    enum Gender
    {
        Male,
        Female
    }

    enum Status
    {
        OpenToWork,
        CloseToWork
    }
    internal abstract class Human
    {
        public static int Count { get; private set; }
        //Properties
        public decimal Budget { get; protected set; }
        public Gender Gender { get; protected set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public int Age { get; protected set; }
        public int ID { get; protected set; }
        public bool IsEmployed { get; protected set; }

        //Fields
        protected Signature Signature;

        //Public Methods

        static Human()
        {
            Count = 0;
        }
        public Human(string name, string surname, Gender gender, int age, decimal budget)
        {
            Gender = gender;
            Name = name;
            Surname = surname;
            Age = age;
            Signature = new Signature(CreatePassword(), ID);
            Budget = budget;
            IsEmployed = false;
            Count++;
            ID = Count;
        }

        public void Represent()
        {
            Console.WriteLine(this.GetType().ToString());
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Gender: " + Gender.ToString());
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Budget: " + Budget);
            Console.WriteLine("Is Employed: " + IsEmployed);
        }


        //Private Methods
        private static string CreatePassword()
        {
            StringBuilder sb = new StringBuilder();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int j = rd.Next(0, 9);
                sb.Append(j + '0');
            }
            return sb.ToString();
        }

        public bool AuthorizeTheSignature(Signature signature)
        {
            return signature == Signature;
        }
    }
}
