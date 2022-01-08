using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance:");
            Console.WriteLine("What is your age?");
            int yourAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? (type \"true\" or \"false\")");
            string DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int yourTickets = int.Parse(Console.ReadLine());

            bool Qualified = (yourAge > 15 && DUI == "false" && yourTickets < 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified);
            Console.ReadLine();
        }
    }
}
