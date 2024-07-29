namespace Task_02
{
    internal class Bird : Animal
    {
        public Bird() { }

        public override void MakeSound()
        {
            Console.WriteLine(Sound);
        }

        static Bird()
        {
            Sound = "Chirp!";
        }
        public static readonly string Sound;
    }
}