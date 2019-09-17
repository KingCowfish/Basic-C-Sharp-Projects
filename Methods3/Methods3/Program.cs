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

            Math add = new Math();
            int k = Convert.ToInt32(add.Mathing(75));
            Console.WriteLine(k);

            Math added = new Math();
            int j = Convert.ToInt32(added.Mathing("27"));
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
