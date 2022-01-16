using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from 1 to 10.");
            int number = int.Parse(Console.ReadLine());
            bool guessedNum = number == 7;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess again?");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                        Console.WriteLine("Guess again?");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess again?");
                        number = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7. That is correct!");
                        guessedNum = true;
                        break;
                    default:
                        Console.WriteLine("You guessed wrong.");
                        Console.WriteLine("Guess again?");
                        number = int.Parse(Console.ReadLine());
                        break;
                }
            }
            while (!guessedNum);
           
            Console.ReadLine();

            Console.WriteLine("Good job on the first one but this is much harder!");
            Console.WriteLine("Guess a number from 1 to 50.");
            int numberH = int.Parse(Console.ReadLine());
            bool hardNum = numberH == 24;

            while (!hardNum)
            {
                switch (numberH)
                {
                    case 24:
                        Console.WriteLine("You guessed 24. That is correct!");
                        hardNum = true;
                        break;
                    default:
                        Console.WriteLine("You guessed wrong.");
                        Console.WriteLine("Guess again?");
                        numberH = int.Parse(Console.ReadLine());
                        break;

                }
            }

            Console.ReadLine();
        }
    }
}
