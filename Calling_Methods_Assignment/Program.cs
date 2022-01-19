using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, lets do some math with methods!");
            Console.WriteLine("Please enter a number.");

            int userIn = Convert.ToInt32(Console.ReadLine());

            Operations Ops = new Operations();

            Console.WriteLine(userIn + " + 12 =");
            int Sum = Ops.Add(userIn);
            Console.WriteLine(Sum);
            Console.ReadLine();

            Console.WriteLine(Sum + " * 5 =");
            int Mul = Ops.Multiply(Sum);
            Console.WriteLine(Mul);
            Console.ReadLine();

            Console.WriteLine(Mul + " / 4 =");
            int Div = Ops.Divide(Mul);
            Console.WriteLine(Div);
            Console.ReadLine();
        }
    }
}
