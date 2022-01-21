using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            Employee.SayName();
            Console.ReadLine();
        }
    }
}
