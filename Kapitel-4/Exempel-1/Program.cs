using System;

namespace Kapitel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // slumpa fram ett tal 1-6
            Random tärning = New random();
            int slumtal = tärning.Next(1, 7);

            // upprepa tills rätt svar gissats
            while (true)

            // läs in användarens gissning
            Console.WriteLine("gissa ett tal (1-6) ?");
            int gissning = int.Parse(Console.ReadLine());

            // om användaren gissat rätt?
            if (gissning == slumptal)
            {
                Console.WriteLine("rätt gissat!");
                break;
            }
            else
            {
                Console.WriteLine("fel gissat! försök igen!");
            }
                // slut
                console.WriteLine("tack för idag!");

        }
    }
}
