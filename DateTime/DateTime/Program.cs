using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = new DateTime();
            currentDateTime = DateTime.Now;
            Console.WriteLine("It is currently " + currentDateTime + ".");
            Console.WriteLine("Please enter a number.");
            int hours = Convert.ToInt32(Console.ReadLine());
            DateTime soon = currentDateTime.AddHours(hours);
            Console.WriteLine("In " + hours + " it will be " + soon + ".");
            Console.ReadLine();
        }
    }
}
