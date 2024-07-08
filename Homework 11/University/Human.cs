using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace University
{
    internal class Human
    {
        protected string Password;

        public UnemployedStatus Status { get; protected set; }
        public bool IsEmployed { get; protected set; }
        public decimal Budget { get; protected set; }
        public Gender Gender { get; protected set; }
        public string Name { get; protected set; }
        public string Surname { get; protected set; }
        public int Age { get; protected set; }
        public string ID { get; protected set; }

        public static bool operator ==(Human h1, Human h2)
        {
            if (h1.Password == h2.Password && h1.ID == h2.ID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Human h1, Human h2)
        {
            return !(h1 == h2);
        }

        public Human(string name, string surname, Gender gender, int age, string id, decimal budget)
        {
            Gender = gender;
            Name = name;
            Surname = surname;
            Age = age;
            ID = id;
            Password = CreatePassword();
            Budget = budget;
        }

        public void ChangeStatus()
        {
            Status = (UnemployedStatus)(1 - (int)Status);
        }
        private static string CreatePassword()
        {
            StringBuilder sb = new StringBuilder();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int j = rd.Next(0, 9);
                sb.Append(j - '0');
            }
            return sb.ToString();
        }
    }
}
