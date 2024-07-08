namespace Task_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of people");
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("First Name:");
                string name = Console.ReadLine();


                Console.WriteLine("Last name:");
                string lastname = Console.ReadLine();


                Console.WriteLine("Age:");
                int age = int.Parse(Console.ReadLine());

                people[i] = new Person(name, lastname, age);
            }

            Console.WriteLine(Person.CalculateTheAvarageAge(people));
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

        public static decimal CalculateTheAvarageAge(Person[] people)
        {
            decimal sum = 0;
            foreach (Person person in people)
            {
                sum += person.Age;
            }
            sum /= people.Length;

            return sum;
        }
    }
}
