using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths adding = new Maths();
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You do not have to, but if you would like to enter a second number, do so now.");
            string opnum = Console.ReadLine();

            if (String.IsNullOrEmpty(opnum))
            {
                Console.WriteLine(adding.Mathing(num1));
                Console.ReadLine();
            }
            else
            {
                int optional = Convert.ToInt32(opnum);
                Console.WriteLine(adding.Mathing(num1, optional));
                Console.ReadLine();
            }
            
            
            

        }
    }
}
