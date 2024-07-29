using System.Drawing;

namespace Task_03
{
    internal class Car : Vechile
    {
        public readonly int SeatsCount;

        public Car(int maxSpeed, int seatsCount) : base(maxSpeed)
        {
            SeatsCount = seatsCount;
        }

        public override void Information()
        {
            Console.WriteLine("Maximal speed: " + MaxSpeed);
            Console.WriteLine("Seats count: " + SeatsCount);
        }
    }
}