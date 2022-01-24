using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Joe", "Bob", "Sue", "Kate" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 2001, 2002, 2003, 2004 };


            for (int i = 0; i < employee2.Things.Count(); i++)
            {
                Console.WriteLine(employee1.Things[i]);
                Console.WriteLine(employee2.Things[i]);
            }
            Console.ReadLine();
        }
    }
}
