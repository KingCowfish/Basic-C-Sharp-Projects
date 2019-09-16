using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Maths
    {
        public void Addition(int num1, int num2)
        {
            int doubled = num1 * 2;
            if (num2 > doubled)
            {
                Console.WriteLine(num2 + " is greater than two times " + num1);
            }
            else
            {
                Console.WriteLine(num2 + " is not greater than two times " + num1);
            }
        }
    }
}
