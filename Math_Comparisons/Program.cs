using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Comparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int Hrate1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Hworked1 = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int Hrate2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int Hworked2 = int.Parse(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 1:");
            int Asalary1 = Hrate1 * (Hworked1 * 52);
            Console.WriteLine(Asalary1);

            Console.WriteLine("Annual salary of Person 2:");
            int Asalary2 = Hrate2 * (Hworked2 * 52);
            Console.WriteLine(Asalary2);

            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool compareIncome = Asalary1 > Asalary2;
            Console.WriteLine(compareIncome);

            Console.ReadLine();
        }
    }
}
