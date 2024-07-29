namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new Motorcycle(80, "black");
            var b = new Car(180, 4);
            var c = new Motorcycle(90, "green");
            var d = new Car(250, 2);

            Vechile[] vechile = new Vechile[] {a, b, c, d };

            foreach (var v in vechile)
            {
                v.Information();
            }

            //Output:
            //Maximal speed: 80
            //Color: black
            //Maximal speed: 180
            //Seats count: 4
            //Maximal speed: 90
            //Color: green
            //Maximal speed: 250
            //Seats count: 2
        }
    }
}
