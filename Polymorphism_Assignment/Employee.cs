using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    public class Employee : Person, IQuittbale
    {
        public new void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + Years);
        }

        public int Years { get; set; }
    }
}
