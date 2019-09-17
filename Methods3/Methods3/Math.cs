using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Math
    {
        public int Mathing(int num1)
        {
            int mult = num1 * 11;
            return mult;
        }

        public decimal Mathing(decimal num1)
        {
            decimal c = num1 + 362;
            return c;
        }

        public string Mathing(string num1)
        {
            int g = Convert.ToInt32(num1);
            int h = g + 27;
            return h.ToString();
        }
    }
}
