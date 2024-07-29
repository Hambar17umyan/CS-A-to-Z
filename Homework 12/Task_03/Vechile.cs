namespace Task_03
{
    internal abstract class Vechile
    {
        public readonly int MaxSpeed;
        public Vechile(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public abstract void Information();
    }
}