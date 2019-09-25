using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraDrills
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employee(string name) : this(name, 50000)
        {
        }
        public Employee(string name, double startSalary)
        {
            Name = name;
            Salary = startSalary;
        }
    }
}
