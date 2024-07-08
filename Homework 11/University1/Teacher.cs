using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University1
{
    internal class Teacher : Human
    {
        //Properties
        public Subject Subject { get; }
        public Status Status { get; protected set; }
        public decimal Salary { get; private set; }
        public University? University { get; private set; }

        //Public methods
        public Teacher(string name, string surname, Gender gender, int age, decimal budget, Status initialStatus, Subject subject, decimal salary) : base(name, surname, gender, age, budget)
        {
            Salary = salary;
            Subject = subject;
            Status = initialStatus;
        }

        public void RepresentTeacher()
        {
            this.Represent();
            Console.WriteLine("Status: " + Status.ToString());
            Console.WriteLine("Salary: " + Salary);
        }
        public bool GetFired(Signature s)
        {
            if (!IsEmployed)
                return false;
            if (University.Rector.AuthorizeTheSignature(s))
            {
                IsEmployed = false;
                University = null;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetHired(Signature s, University u)
        {
            if (IsEmployed)
                return false;
            if (u.Rector.AuthorizeTheSignature(s))
            {
                IsEmployed = true;
                University = u;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Quit(Status newStatus)
        {
            if (!IsEmployed)
                return false;
            University.DeleteTeacher(this, Signature);
            IsEmployed = false;
            University = null;
            Status = newStatus;

            return true;
        }

        public void ChangeTheStatus()
        {
            Status = (Status)(1 - (int)Status);
        }
    }

    enum Subject
    {
        None = 0,
        English = 1,
        Mathematics = 2,
        Physics = 3,
        Informatics = 4,
        PE = 5,
        Art = 6
    }
}
