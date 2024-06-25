using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 10:
            Pizza Toppings Enum:
            Design an enum for pizza toppings (e.g., Pepperoni, Mushroom, Onion). Allow users to customize their pizza order using this enum.
			*/
            Console.WriteLine("Welcome to our pizzeria. Please choose your own toppings from the list!");
            Topping pizza = new Topping();
            bool AnyTopping = false;
            for (int i = 1; i < 64; i <<= 1)
            {
                Console.WriteLine("Would you like me to add " + (Topping)i);
                Console.WriteLine("...Write \"Yes\" or \"No\"!...");
                string input = Console.ReadLine();
                if (input == "Yes")
                {
                    pizza |= (Topping)i;
                    AnyTopping = true;
                }
                else if (input != "No")
                {
                    Console.WriteLine("Please write exactly \"Yes\" or \"No\"!");
                    i >>= 1;
                }
            }

            if (!AnyTopping)
            {
                Console.WriteLine("We are sorry but we cannot give you an empty pizza. You can buy it in our store.");
                return;
            }
            Console.WriteLine($"So your pizza contains {pizza}.");
            Console.WriteLine("Bon Appsetit");
        }
    }

    [Flags]
    enum Topping
    {
        None,
        Pepperoni,
        Mushroom,
        Onion = 4,
        Olive = 8,
        Tomato = 16,
        Pepper = 32,
    }
}