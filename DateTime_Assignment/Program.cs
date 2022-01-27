using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime currentTime = DateTime.Now;

            Console.WriteLine("Please enter a number to add hours onto the current time.");
            DateTime userHourLater = currentTime.AddHours(Convert.ToDouble(Console.ReadLine()));
            
                        

            Console.WriteLine(string.Format("{0} Will be... {1}", currentTime, userHourLater));

            Console.ReadLine();
        }
    }
}
