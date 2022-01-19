using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite Pet?");

            string userIn = Console.ReadLine();

            string[] petTraits = { "Good pet: ", "Fun friend: ", "Affectionate: ", "Intelligent: ", "Loyal: " };

            for (int i = 0; i < petTraits.Length; i++)
            {
                Console.WriteLine(petTraits[i] + userIn);
            }
            for (int j = 0; j < petTraits.Length; j++)
            {
                Console.WriteLine(petTraits[j]);
            }

            while (true)
            {
                Console.WriteLine("This is never going to stop!");
                break;
            }

            for (int z = 0; z < 4; z++)
            {
                Console.WriteLine(z);
            }

            for (int y = 0; y <= 5; y++)
            {
                Console.WriteLine(y);
            }

            List<string> names = new List<string>() { "Nathan", "Nolan", "Kaylee", "Ben" };

            Console.WriteLine("Search for a name");
            string userSearch = Console.ReadLine();
            bool found = false;

            for (int i =0; i < names.Count; i++)
            {
                if (names[i] == userSearch)
                {
                    Console.WriteLine(i + " is the index of " + userSearch);
                    found = true;
                    break;
                }  
            }

            if (!found)
            {
                Console.WriteLine("That name is not in the list.");
            }

            List<string> names2 = new List<string>() { "Nathan", "Nolan", "Kaylee", "Ben", "Nolan", "Kaylee" };

            Console.WriteLine("Search for a name");
            string userSearch2 = Console.ReadLine();
            
            if (names2.Contains(userSearch2))
            {
                for (int i = 0; i < names2.Count; i++)
                {
                    if (names2[i] == userSearch2)
                    {
                        Console.WriteLine(i + " is the index of " + userSearch2);
                    }

                }
            }

            else
            {
                Console.WriteLine("That name is not in the list.");
            }



            List<string> nameEachs = new List<string>() { "Emma", "Bob", "Joe", "Ben", "Bob", "Joe" };

            Console.WriteLine("Search for a name");

            foreach (string nameEach in nameEachs)
            {
                Console.WriteLine(nameEach);
            }




            Console.ReadLine();

        }
    }
}
