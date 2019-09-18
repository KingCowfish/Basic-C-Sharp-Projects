using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee n = new Employee();
            //n.FirstName = "Sample";
            //n.LastName = "Student";
            //n.SayName();
            //Console.ReadLine();

            Employee e1 = new Employee();
            e1.ID = 64;

            Employee e2 = new Employee();
            e2.ID = 64;

            if (e1 == e2)
            {
                Console.WriteLine("These IDs belong to the same employee");
            }
            else
            {
                Console.WriteLine("These IDs belong to two different employees.");
            }
            Console.ReadLine();

        }
    }
}
