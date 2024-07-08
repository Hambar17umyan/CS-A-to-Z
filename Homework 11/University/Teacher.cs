namespace University
{
    internal class Teacher : Human
    {
        public Subject Subject { get; }
        public decimal Salary { get; private set; }
        public University? University { get; private set; }


        public void TryQuit(out bool success, UnemployedStatus newStatus)
        {
            success = true;
            if (!IsEmployed)
            {
                success = false;
            }
            else
            {
                University.TryRemoveTeacher(this, Signiture, out success);

                if (!success)
                    return;
                University = null;
                Status = newStatus;
            }
        }

        public void TryAddUniversity(University university, Signiture signiture, out bool success)
        {
            success = true;
            if (this.isValidSigniture(signiture) && Status != Status.Employed)
            {
                Status = Status.Employed;
                University = university;
            }
            else
            {
                success = false;
            }
        }

        public void TryRemoveUniversity(University university, Signiture signiture, out bool success)
        {
            success = true;
            if (university == University && university.Rector.isValidSigniture(signiture))
            {
                University = null;
            }
            else success = false;
        }

        public Teacher(Human h, Subject subject, decimal salary) : base(h.Name, h.Surname, h.Gender, h.Age, h.ID, h.Budget)
        {
            Salary = salary;
            Status = UnemployedStatus.OpenToWork;
            Subject = subject;
        }
    }

}
