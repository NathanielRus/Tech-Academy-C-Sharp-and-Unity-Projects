using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            Employee.SayName();

            IQuittbale person = new Employee() { FirstName = "Sample", LastName = "Student", Years = 5 };
            person.Quit();

            Console.ReadLine();
        }
    }
}
