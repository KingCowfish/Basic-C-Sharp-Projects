using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.ID.Equals(emp2.ID))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return (!(emp1.ID.Equals(emp2.ID)));
        }


    }
}
