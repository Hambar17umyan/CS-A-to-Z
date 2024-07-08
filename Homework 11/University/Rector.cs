namespace University
{
    internal class Rector : Human
    {
        public University University { get; private set; }
        public Rector(Human h) : base(h.Name, h.Surname, h.Gender, h.Age, h.ID, h.Budget)
        {
            
        }


        public bool SetUniversity(University university)
        {
            if (this.Equals(university.Rector) && !IsEmployed && Status == UnemployedStatus.OpenToWork)
                University = university;
            else return false;
            return true;
        }

        //public void Hire(Teacher t, out bool success)
        //{
        //   // University.TryHireTeacher(t, Signiture, out success);
        //}

        //public void Fire(Teacher t, out bool success)
        //{
        //  //  University.TryFireTeacher(t, Signiture, out success);
        //}
    }
}
