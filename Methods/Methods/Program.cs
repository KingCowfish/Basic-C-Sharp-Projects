using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number that you wish me to use my magical methods on.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Math stats = new Math();
            Console.WriteLine(stats.Division(num1));
            Console.WriteLine(stats.Multiply(num1));
            Console.WriteLine(stats.Addition(num1));
            Console.ReadLine();
        }
    }
}
