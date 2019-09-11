using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a whole number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now pick another whole number which is bigger than your first number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (num1 <= num2)
            {
                sum += num1;
                num1++;
            }

            Console.WriteLine("If you add all the numbers from your first number to your second number, they will " +
                "equal " + sum + ".");

            Console.WriteLine("Now, can you guess how much money is in my wallet?");
            int funds = Convert.ToInt32(Console.ReadLine());

            bool money = funds == 0;

            do
            {
                switch (funds)
                {
                    case 5:
                        Console.WriteLine("Close but no cigar!  Try again.");
                        funds = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("In the ballpark, but not quite there.  Try again.");
                        funds = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 20:
                        Console.WriteLine("There be no Jacksons in my wallet.  Try again.");
                        funds = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 50:
                        Console.WriteLine("Nope, I definitely don't have that much.  Try again.");
                        funds = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 100:
                        Console.WriteLine("Not even close!  Try again.");
                        funds = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 0:
                        Console.WriteLine("Yep!  I is broke!");
                        Console.ReadLine();
                        money = true;
                        break;
                    default:
                        Console.WriteLine("Nope, try again.");
                        funds = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!money);
        }
    }
}
