using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DayOfWeek days;
            Console.WriteLine("Please enter in the current day of the week.");
            string InDay = Console.ReadLine();

            try
            {
                days = (DayOfWeek)Enum.Parse(typeof(DayOfWeek),InDay);
                Console.WriteLine("Today is: " + InDay);

            }


            catch (Exception)
            {

                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();

        }     
    }
}
