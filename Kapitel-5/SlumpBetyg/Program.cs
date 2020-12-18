using System;

namespace SlumpBetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            // slumpa fram ett betyg: F, E, D, C, B, A 
            // slumpa fram ett tal (1-6)
            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6);

            // Skriv ut slumptalet
            System.Console.WriteLine($"Slumptalet = {slumptal}");

            // skapa en array av betygen "F", "E", "D", "c", "B", "A"
            string[] Betyg = { "F", "E", "D", "C", "B", "A" };

            //skriv ut slumpat betyg
            System.Console.WriteLine($"ditt betyg är {Betyg[slumptal]}");


        }


    }



}
