using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express (not to be confused with Panda Express...)." +
                "Please follow the instructions below.");
            Console.WriteLine("Please enter the weight of the package you wish to send.");
            float weight = float.Parse(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("We are sorry, but your package is too heavy to be shipped via Package " +
                "Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the width of the package you wish to send.");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the height of the package you wish to send.");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the length of the package you wish to send.");
            float length = float.Parse(Console.ReadLine());
            float dimensions = width + height + length;

            if (dimensions > 50)
            {
                Console.WriteLine("We are sorry, but your package is too big to be shipped via Package " +
                "Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            decimal totalCost = Convert.ToDecimal(dimensions * weight / 100);
            string formattedCost = string.Format("{0:C}", totalCost);

            Console.WriteLine("The total cost to ship your package is: " + formattedCost + ".");
            Console.ReadLine();

        }
    }
}
