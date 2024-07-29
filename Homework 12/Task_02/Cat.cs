namespace Task_02
{
    internal class Cat : Animal
    {
        public Cat() { }

        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        static Cat()
        {
            Sound = "Meow!";
        }
        public static readonly string Sound;
    }
}