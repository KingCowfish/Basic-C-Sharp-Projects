using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a number.");
            string multiplication = Console.ReadLine();
            decimal mult = Convert.ToDecimal(multiplication);
            decimal multot = mult * 50;
            Console.WriteLine("Your number multiplied by 50 is " + multot + ".");

            Console.WriteLine("Please type in another number.");
            string addition = Console.ReadLine();
            decimal add = Convert.ToDecimal(addition);
            decimal addtot = add + 25;
            Console.WriteLine("Your number plus 25 is " + addtot + ".");

            Console.WriteLine("Please type in a third number.");
            string division = Console.ReadLine();
            float div = float.Parse(division);
            float divtot = div / (float)12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divtot + ".");

            Console.WriteLine("Please type in a fourth number.");
            string comparison = Console.ReadLine();
            decimal comp = Convert.ToDecimal(comparison);
            bool comtot = comp > 50;
            
            if (comtot == true)
            {
                Console.WriteLine("Your number is greater than 50!");
            }
            else
            {
                Console.WriteLine("Your number is less than 50.");
            }

            Console.WriteLine("Please type in one last number.");
            string modulus = Console.ReadLine();
            decimal mod = Convert.ToDecimal(modulus);
            decimal modtot = mod % 7;
            Console.WriteLine("Your number, when divided by 7, has a remainder of " + modtot + ".");
            Console.ReadLine();
           
        }
    }
}
