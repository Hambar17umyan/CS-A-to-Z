using System.Collections;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo("Gazananoc");
            zoo.AddAnimal(new Animal(AnimalType.Elephant, "Vova"));
            zoo.AddAnimal(new Animal(AnimalType.Kangaroo, "Jack"));
            zoo.AddAnimal(new Animal(AnimalType.Snake, "Kai"));
            zoo.AddAnimal(new Animal(AnimalType.Monkey, "Marcel"));
            zoo.AddAnimal(new Animal(AnimalType.Tiger, "Lance"));
            zoo.AddAnimal(new Animal(AnimalType.Lion, "Alex"));

            ZooKeeper zooKeeper = new ZooKeeper(zoo);

            zooKeeper.AskForHelp();
        }
    }

    class ZooKeeper
    {
        public readonly Zoo Zoo;
        public ZooKeeper(Zoo zoo)
        {
            Zoo = zoo;
        }

        public void AskForHelp()
        {
            foreach (var a in Zoo)
            {
                (a as Animal).Introduction();
            }
        }
    }

    class Zoo : IEnumerable
    {
        public readonly string Name;
        private List<Animal> Animals;

        public Zoo(string name)
        {
            Name = name;
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        private class Enumerator : IEnumerator
        {
            private List<Animal> Animals => Zoo.Animals;
            private Zoo Zoo;
            private int index;
            public Enumerator(Zoo zoo)
            {
                index = 0;
                Zoo = zoo;
            }
            public object Current => (Animals[index]);

            public bool MoveNext()
            {
                index++;
                if (index >= Animals.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                index = 0;
            }
        }
    }

    class Animal
    {
        public readonly AnimalType Type;
        public readonly string Name;

        public Animal(AnimalType type, string name)
        {
            Type = type;
            Name = name;
        }

        public void Introduction()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine(new string('-', 15));
        }
    }

    enum AnimalType
    {
        Lion,
        Tiger,
        Elephant,
        Monkey,
        Snake,
        Kangaroo,
        Deer
    }
}
