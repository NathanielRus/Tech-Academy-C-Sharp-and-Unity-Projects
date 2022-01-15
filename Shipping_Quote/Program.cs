using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the package weight?");
            int packageW = int.Parse(Console.ReadLine());

            if (packageW > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.WriteLine("What is the Package width?");
            int packageWidth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Package height?");
            int packageHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Package length?");
            int packageLength = int.Parse(Console.ReadLine());

            if (packageWidth + packageHeight + packageLength > 50)
            {
                Console.WriteLine("The Package is too big to be shipped via Package Express.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            decimal quote = (packageWidth * packageHeight * packageLength) * packageW / 100;

            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C2"));
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
