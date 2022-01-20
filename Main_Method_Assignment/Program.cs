using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, lets do some math with methods!");
            Console.WriteLine("Please enter a number.");


            int userIn = Convert.ToInt32(Console.ReadLine());

            Math Ops = new Math();

            Console.WriteLine(userIn + " + 12 =");
            int Sum = Ops.Add(userIn);
            Console.WriteLine(Sum);

            Console.WriteLine("Good, now type in a decimal!");
            decimal decIn = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(decIn + " + 25 =");
            decimal dec = Ops.Add(decIn);
            Console.WriteLine(dec);

            Console.WriteLine("Nice, now type in another number.");
            string strIn = Console.ReadLine();


            Console.WriteLine(strIn + " * " + userIn + " / 2 =");
            int newInt = Ops.Add(strIn, userIn);
            Console.WriteLine(newInt);
            Console.ReadLine();
        }
    }
}
