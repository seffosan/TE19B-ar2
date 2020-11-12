using System;

namespace Uppgift_1_4
{

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Vilket är världens största land?");
            string svar = Console.ReadLine();
            while (svar != "Ryssland")
            {
                Console.WriteLine("Du svarade fel, försök igen");
                svar = Console.ReadLine();
            }
            Console.WriteLine("Grattis! Du svarade rätt! Gå ät en pizza för att fira!");

        }

    }
}