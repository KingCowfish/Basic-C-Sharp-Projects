using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1:");
            Console.WriteLine("What is your hourly rate?");
            string person1rate = Console.ReadLine();
            float p1rate = float.Parse(person1rate);
            Console.WriteLine("How many hours did you work this week?");
            string person1hours = Console.ReadLine();
            float p1hours = float.Parse(person1hours);
            float p1salary = p1rate * p1hours;

            Console.WriteLine("Person 2:");
            Console.WriteLine("What is your hourly rate?");
            string person2rate = Console.ReadLine();
            float p2rate = float.Parse(person2rate);
            Console.WriteLine("How many hours did you work this week?");
            string person2hours = Console.ReadLine();
            float p2hours = float.Parse(person2hours);
            float p2salary = p2rate * p2hours;

            bool comparison = p1salary > p2salary;

            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine("$" + p1salary + ".");
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine("$" + p2salary + ".");
            Console.WriteLine("Does Person 1 make more money than Person 2?");

            if (comparison == true)
            {
                Console.WriteLine("Yes, Person 1 does make more money then Person 2.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No, Person 1 does not make more money than Person 2.");
                Console.ReadLine();
            }
        }
    }
}
