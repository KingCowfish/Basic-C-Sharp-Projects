using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.firstName = "Sample";
            name.lastName = "Employee";
            name.SayName();
            Console.ReadLine();

        }
    }
}
