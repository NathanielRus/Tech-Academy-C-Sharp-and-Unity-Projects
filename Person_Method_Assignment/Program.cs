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
            Person Person = new Employee() { FirstName = "Sample", LastName = "Student" };

            Person.SayName();
            Console.ReadLine();
        }
    }
}
