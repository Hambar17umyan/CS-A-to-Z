using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
			Task 21:
            Enum-Based Strategy Pattern:
            Define an enum for payment gateways (e.g., PayPal, Stripe, CreditCard).
            Implement a strategy pattern where each enum value corresponds to a different payment processing strategy.
			*/
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine(i + $".{(PaymentMethod)i}");
            }
        }
    }
    enum PaymentMethod
    {
        None,
        Arca,
        MasterCard,
        VisaCard,
        PayPal,
        IDram,
        TelCell
    }
}