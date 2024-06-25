using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 4:
            Enum with Associated Values:
            Create an enum for different types of vehicles (e.g., Car, Bus, Bicycle). Each enum value can have associated properties like maximum speed, fuel efficiency, etc.
			*/
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"The results for {(transport)i}");
                Console.WriteLine($"Maximum speed: {Speed((transport)i)}");
                Console.WriteLine($"Fuel efficiency: {FuelEfficiency((transport)i)}");
                Console.WriteLine($"Cost efficiency: {CostEfficiency((transport)i)}");
                Console.WriteLine(new string('-', 15));
            }

            Console.WriteLine("If you want to see what will happen with a \'None\' transport, press any button.");
            Console.ReadKey();
            Console.WriteLine(Speed(new transport()));
            Console.WriteLine(FuelEfficiency(new transport()));
            Console.WriteLine(CostEfficiency(new transport()));
        }
        static int Speed(transport transport)
        {
            switch (transport)
            {
                case transport.Bus:
                    return 90;
                case transport.Bisycle:
                    return 30;
                case transport.Car:
                    return 200;
                case transport.Plane:
                    return 900;
                case transport.Train:
                    return 300;
                case transport.Yacht:
                    return 60;
            }
            throw new Exception("Not a right transport! Use only Bus\nBisycle\nCar\nPlane\nTrain\nYacht");
        }

        static double FuelEfficiency(transport transport)
        {
            switch (transport)
            {
                case transport.Bus:
                    return 5.5;
                case transport.Bisycle:
                    return 10.0;
                case transport.Car:
                    return 6.8;
                case transport.Plane:
                    return 3.5;
                case transport.Train:
                    return 7.2;
                case transport.Yacht:
                    return 4.0;
            }
            throw new Exception("Not a right transport! Use only Bus\nBisycle\nCar\nPlane\nTrain\nYacht");
        }
        static double CostEfficiency(transport transport)
        {
            switch (transport)
            {
                case transport.Bus:
                    return 7.5;
                case transport.Bisycle:
                    return 10.0;
                case transport.Car:
                    return 7.0;
                case transport.Plane:
                    return 8.0;
                case transport.Train:
                    return 8.0;
                case transport.Yacht:
                    return 5.0;
            }
            throw new Exception("Not a right transport! Use only Bus\nBisycle\nCar\nPlane\nTrain\nYacht");
        }
    }
    enum transport
    {
        None,
        Bus,
        Bisycle,
        Car,
        Plane,
        Train,
        Yacht
    }
}