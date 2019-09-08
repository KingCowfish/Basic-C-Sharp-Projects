using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number are you on in the course?");
            string coursePage = Console.ReadLine();
            int cPage = Convert.ToInt32(coursePage);
            Console.WriteLine("Do you need any assistance with anything?  Please answer \"true\" or \"false\"");
            string courseHelp = Console.ReadLine();
            bool cHelp = Convert.ToBoolean(courseHelp);
            Console.WriteLine("Any positive experiences you'd like to share?  Please be specific.");
            string coursePosExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?  Please be specific.");
            string courseFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string courseStudy = Console.ReadLine();
            int cStudy = Convert.ToInt32(courseStudy);
            Console.WriteLine("Thank you for your answers!  An instructor will respond shortly.  Have a great day!");
            Console.ReadLine();
        }
    }
}
