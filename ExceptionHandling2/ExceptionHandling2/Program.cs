using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("How old are you?");
                int yearsOld = Convert.ToInt32(Console.ReadLine());
                if (yearsOld == 0 || yearsOld < 0)
                {
                    throw new ArgumentException();
                }

                DateTime today = DateTime.Today;
                var year = today.Year;
                int yearBorn = Convert.ToInt32(year) - yearsOld;
                Console.WriteLine("You were born in " + yearBorn + ".");
                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You can't really be that young.  Please enter a whole number larger than zero next time.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a whole number next time.");
            }
            finally
            {
                Console.ReadLine();
            }
}
    }
}
