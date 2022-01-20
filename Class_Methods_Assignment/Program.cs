using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_Assignment
{
    static class Program
    {
        static void Main(string[] args)
        {
            Math Ops = new Math();


            Console.WriteLine("Hi, please enter a number.");
            Ops.Operations(UserIn1: Convert.ToInt32(Console.ReadLine()));

            

            Console.WriteLine("Good now enter a different number.");
            Ops.Operations(DiffNum: Convert.ToInt32(Console.ReadLine()),Hardnum: 10);

            

            Console.WriteLine("Now the computer will give you a number.");
            int inMethod;
            Ops.OutArg(out inMethod);
            Console.WriteLine(inMethod);

            Console.ReadLine();
        }
    }
}
