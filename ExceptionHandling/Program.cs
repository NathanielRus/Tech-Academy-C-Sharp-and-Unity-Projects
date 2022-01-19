using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Here is a list of numbers.");
                List<int> randos = new List<int>() { 10, 12, 23, 7 };

                foreach (int rando in randos)
                {
                    Console.WriteLine(rando);
                }

                Console.WriteLine("Now choose a number to divide them by.");
                int userInput = int.Parse(Console.ReadLine());

                foreach (var rando in randos)
                {
                    var result = rando / userInput;
                    Console.WriteLine(result);
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
            
        }
    }
}
