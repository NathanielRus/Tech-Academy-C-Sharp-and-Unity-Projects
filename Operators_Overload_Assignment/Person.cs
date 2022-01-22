using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload_Assignment
{
    class Person
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
