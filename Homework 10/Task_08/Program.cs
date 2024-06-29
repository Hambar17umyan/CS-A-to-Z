namespace Task_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(int.TryParse(Console.ReadLine(), out var value))
            {
                Console.WriteLine(Fibonacci(value));
            }
            else Console.WriteLine("Wrong input!");
        }

        static int Fibonacci(int index)
        {
            if(index == 1 || index == 2)
            {
                return 1;
            }
            return Fibonacci(index - 1) + Fibonacci(index - 2);
        }
    }
}