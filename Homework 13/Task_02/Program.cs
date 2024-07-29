namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            IAnimal animal = dog;

            animal.Eat();
            animal.Sleep(); 
        }
    }
    interface IAnimal
    {
        void Eat();
        void Sleep();
    }

    class Dog : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("The dog is eating.");
        }

        void IAnimal.Sleep()
        {
            Console.WriteLine("The dog is sleeping.");
        }
    }
}
