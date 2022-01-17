using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, lets pay a game!");
            Console.WriteLine("Choose a number for the color! 0 through 3.");
            int numColor = int.Parse(Console.ReadLine());

            string[] colorArray = { "Red", "Blue", "Green", "Yellow" };

            if (numColor > 3)
            {
                Console.WriteLine("That is not an option!");
                System.Environment.Exit(0);
            }

            Console.WriteLine(colorArray[numColor]);

            Console.WriteLine("Good, Now choose a random number from 0 through 4!");
            int ranNumber = int.Parse(Console.ReadLine());

            int[] Age = { 20, 30, 40, 50, 60 };

            if (ranNumber > 4)
            {
                Console.WriteLine("That is not an option!");
                System.Environment.Exit(0);
            }

            Console.WriteLine(Age[ranNumber]);

            Console.WriteLine("Great, 1 last time! Choose 0 through 3.");
            int ranString = int.Parse(Console.ReadLine());

            List<string> Quote = new List<string>();
            Quote.Add("I'm not superstitious, but I am a little stitious.");
            Quote.Add("Before you marry a person, you should first make them use a computer with slow internet to see who they really are.");
            Quote.Add("Ned, I would love to stand here and talk with you—but I’m not going to.");
            Quote.Add("There is no sunrise so beautiful that it is worth waking me up to see it.");

            if (ranString > 3)
            {
                Console.WriteLine("That is not an option!");
                System.Environment.Exit(0);
            }

            Console.WriteLine("Great now for the results!");
            Console.WriteLine("Your favorite color is: " + colorArray[numColor]);
            Console.WriteLine("Your Age is: " + Age[ranNumber]);
            Console.WriteLine("Your Quote for the year: " + Quote[ranString]);

            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();
        }
    }
}
