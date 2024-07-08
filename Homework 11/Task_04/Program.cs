namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Biden = new Person("Joe", "Biden", 81);
            Person Trump = new Person("Donald", "Trump", 78);
            Person Obama = new Person("Barack", "Obama", 62);
        }
    }

    struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
