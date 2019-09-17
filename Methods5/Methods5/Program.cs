using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Program
    {
        static void Main(string[] args)
        {
            Division div = new Division();
            Console.WriteLine("Input a number to be divided by 2.");
            int g = Convert.ToInt32(Console.ReadLine());
            div.divide(g);

            Division div2 = new Division();
            Console.WriteLine("Input another number to be messed with.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(div2.divide(num1));

            int outputin; 
            Addition.outex(out outputin);

            Console.ReadLine();
            

        }
    }
}
