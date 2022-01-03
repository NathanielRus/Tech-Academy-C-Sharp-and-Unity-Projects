using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int coursePage = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string TorF = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(TorF);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string pExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedBack = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int studyHours = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");


            Console.ReadLine();
        }
    }
}
