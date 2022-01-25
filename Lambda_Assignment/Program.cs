using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                FName = "Joe",
                LName = "Russell",
            };

            Employee emp2 = new Employee()
            {
                ID = 102,
                FName = "Joe",
                LName = "Living",
            };

            Employee emp3 = new Employee()
            {
                ID = 103,
                FName = "Nathan",
                LName = "Smith",
            };

            Employee emp4 = new Employee()
            {
                ID = 104,
                FName = "Lexy",
                LName = "Birr",
            };

            Employee emp5 = new Employee()
            {
                ID = 105,
                FName = "Emma",
                LName = "Hawking",
            };

            Employee emp6 = new Employee()
            {
                ID = 106,
                FName = "John",
                LName = "Wick",
            };

            Employee emp7 = new Employee()
            {
                ID = 107,
                FName = "Ben",
                LName = "Dillon",
            };

            Employee emp8 = new Employee()
            {
                ID = 108,
                FName = "Kaylee",
                LName = "Davis",
            };

            Employee emp9 = new Employee()
            {
                ID = 109,
                FName = "Milton",
                LName = "Rogan",
            };

            Employee emp10 = new Employee()
            {
                ID = 110,
                FName = "Sarrah",
                LName = "Conner",
            };


            List<Employee> listEmployees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };
            List<Employee> ListJoe = new List<Employee>();

            int i = 0;
            foreach (Employee e in listEmployees)
            {
                if (e.FName == ("Joe"))
                {
                    ListJoe.Add(e);
                    i++;
                }

            }

            

            List<Employee> ListJoe2 = listEmployees.Where(x => x.FName == "Joe").ToList();

            List<Employee> ID5 = listEmployees.Where(x => x.ID > 105).ToList();
            Console.ReadLine();
        }
    }
}
