using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Maths
    {
        public int Mathing(int num1, int optional = 10)
        {
            int k = num1 + 64 - optional;
            return k;
        }
    }
}
