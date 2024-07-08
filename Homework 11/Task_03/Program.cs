namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Biden = new Person("Joe", "Biden", 81);
            Console.WriteLine(Biden.FirstName);
            Console.WriteLine(Biden.LastName);
            Console.WriteLine(Biden.Age);
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
