namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success;
            var res = GetPersonInfo(out success);
            if(!success)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine($"Name: {res.name}\nAge: {res.age}\nIs adult?: {res.isAdult}");
            }
        }

        static (string name, int age, bool isAdult) GetPersonInfo(out bool success)
        {
            success = true;
            string name = Console.ReadLine();
            if(int.TryParse(Console.ReadLine(), out int age))
            {
                return (name, age, age >= 18);
            }
            success = false;
            return ("", 0, false);
        }
    }
}
