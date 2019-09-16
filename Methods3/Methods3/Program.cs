using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math multi = new Math();
            Console.WriteLine(multi.Mathing(12));

            Math sub = new Math();
            Console.WriteLine(sub.Mathing(-75));

            Math added = new Math();
            Console.WriteLine(added.Mathing("27"));
            Console.ReadLine();
        }
    }
}
