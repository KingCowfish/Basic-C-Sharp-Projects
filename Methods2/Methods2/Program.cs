using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 60;
            Maths great = new Maths();
            great.Addition(num1: 20, num2: 60);
            Console.ReadLine();
        }
    }
}
