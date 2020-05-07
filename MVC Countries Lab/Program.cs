using System;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();
            cc.WelcomeAction();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to learn about another country?");
                string answer = Console.ReadLine().ToLower().Trim();
                if (answer == "y")
                {
                    Console.WriteLine();
                    cc.WelcomeAction();
                }
                else if (answer == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye");
                    break;
                }
            }
        }
    }
}
