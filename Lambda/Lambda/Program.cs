using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListEmp = new List<Employee>();

            Employee emp1 = new Employee() { firstName = "Joe", lastName = "Dirt", ID = 1 };
            Employee emp2 = new Employee() { firstName = "Eddie", lastName = "Vedder", ID = 2 };
            Employee emp3 = new Employee() { firstName = "Chris", lastName = "Cornell", ID = 3 };
            Employee emp4 = new Employee() { firstName = "Scott", lastName = "Weiland", ID = 4 };
            Employee emp5 = new Employee() { firstName = "Lane", lastName = "Staley", ID = 5 };
            Employee emp6 = new Employee() { firstName = "Gavin", lastName = "Rossdale", ID = 6 };
            Employee emp7 = new Employee() { firstName = "James", lastName = "Maynard", ID = 7 };
            Employee emp8 = new Employee() { firstName = "Billy", lastName = "Corga", ID = 8 };
            Employee emp9 = new Employee() { firstName = "Ed", lastName = "Roland", ID = 9 };
            Employee emp10 = new Employee() { firstName = "Joe", lastName = "Walsh", ID = 2 };
            ListEmp.Add(emp1);
            ListEmp.Add(emp2);
            ListEmp.Add(emp3);
            ListEmp.Add(emp4);
            ListEmp.Add(emp5);
            ListEmp.Add(emp6);
            ListEmp.Add(emp7);
            ListEmp.Add(emp8);
            ListEmp.Add(emp9);
            ListEmp.Add(emp10);

            List<Employee> jNames = new List<Employee>();

            foreach (Employee fname in ListEmp)
            {
                if (fname.firstName == "Joe")
                {
                    jNames.Add(fname);                    
                }
            }


            List<Employee> namesJ = ListEmp.Where(x => x.firstName == "Joe").ToList();

            List<Employee> hiID = ListEmp.Where(x => x.ID < 5).ToList();

            Console.ReadLine();



        }
    }
}
