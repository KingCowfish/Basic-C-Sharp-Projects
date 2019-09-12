using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(22);
                numbers.Add(43);
                numbers.Add(2);
                numbers.Add(67);
                numbers.Add(210);
                Console.WriteLine("Please pick a number.");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] / num);
                }
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter a single number.");
            }
            finally
            {
                Console.WriteLine("Good day to you!");
                Console.ReadLine();
            }

        }
    }
}
