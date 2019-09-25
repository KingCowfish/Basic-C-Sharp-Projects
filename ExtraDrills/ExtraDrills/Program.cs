using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDrills
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Alex");
            const double standardRaise = .04;
            Console.WriteLine("Would you like to give {0} a standard raise?", emp.Name);
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" || answer == "yea")
            {
                var raiseStand = emp.Salary + (emp.Salary * standardRaise);
                Console.WriteLine(emp.Name + " will now be making " + raiseStand + " per year.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What percentage would you like to raise " + emp.Name + "'s yearly salary by?");
                var mon = Convert.ToDouble(Console.ReadLine());
                var raise = emp.Salary + (emp.Salary * mon);
                Console.WriteLine(emp.Name + " will now be making " + raise + " per year.");
                Console.ReadLine();
            }
        }
    }
}
