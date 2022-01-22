using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Overload_Assignment
{
    class Employee : Person
    {
        public int Id { get; set; }

        public static Employee operator== (Employee employee, Employee employee2)
        {
            employee.Id.Equals(employee2.Id);
            return employee;
        }

        public static Employee operator!= (Employee employee, Employee employee2)
        {
            employee.Id.Equals(employee2.Id);
            return employee;
        }
    }
}
