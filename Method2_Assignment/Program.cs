using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            Math Ops = new Math();
            

            Console.WriteLine("Hi, please enter a number.");
            Ops.userIn1 = Convert.ToInt32(Console.ReadLine());
            

            try
            {
                Console.WriteLine("Good, now enter another number. You do not have to enter a 2nd number.");
                Ops.userIn2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("You skipped the second number.");
                Ops.userIn2 = 0;
            }
            int Operation = Ops.Add(Ops.userIn1, Ops.userIn2);
            Console.WriteLine("The sum of " + Ops.userIn1 + " * " + Ops.userIn2 + " = " + Operation);
            
            Console.ReadLine();
        }
    }
}
