using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Successful Cars And Machinery Insurance!");
            Console.WriteLine("Please answer the following questions to find out if you are eligible " +
                "to purchase the best car insurance in the whole universe!");
            Console.WriteLine("First up, how old are you?");
            string howOld = Console.ReadLine();
            int age = Convert.ToInt32(howOld);
            Console.WriteLine("True or false: Have you ever had a DUI?");
            string drunk = Console.ReadLine();
            bool wino = Convert.ToBoolean(drunk);
            Console.WriteLine("How many speeding tickets have you ever received?");
            string reckless = Console.ReadLine();
            int danger = Convert.ToInt32(reckless);

            if (age > 15 && wino == false && danger <= 3)
            {
                Console.WriteLine("Congratulations!  You are eligible to purchase SCAM Insurance!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Unfortunately, due to your answers, we have considered you a danger to society " +
                    "and generally just a bad person.  Therefore, you are not elegible to purchase SCAM Insurance.");
                Console.ReadLine();
            }



        }
    }
}
