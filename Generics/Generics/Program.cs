using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> candy = new Employee<string>();
            candy.Things = new List<string>();
            candy.Things.Add("Snickers");
            candy.Things.Add("Milky Way");
            candy.Things.Add("Three Musketeers");

            Employee<int> num = new Employee<int>();
            num.Things = new List<int>();
            num.Things.Add(4);
            num.Things.Add(19);
            num.Things.Add(76);
            num.Things.Add(2391);

            Console.WriteLine("Here is a list of things:");

            for (int i = 0; i < candy.Things.Count;)
            {
                Console.WriteLine(candy.Things[i]);
                i++;

                if (i == candy.Things.Count)
                {
                    for (int j = 0; j < num.Things.Count; j++)
                    {
                        Console.WriteLine(num.Things[j]);
                    }
                }
            }
            Console.ReadLine();



        }
    }
}
