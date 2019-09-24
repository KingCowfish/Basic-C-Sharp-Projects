using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Users\brode\Desktop\log.txt", number);
            Console.WriteLine(File.ReadAllText(@"C:\Users\brode\Desktop\log.txt"));
            Console.ReadLine();
        }
    }
}
