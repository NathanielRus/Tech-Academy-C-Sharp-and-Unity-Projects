using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            Employee Employee2 = new Employee() { FirstName = "Nathaniel", LastName = "Russell", Id = 2 };

            Console.WriteLine(Employee.Id == Employee2.Id);


            Console.ReadLine();
        }
    }
}
