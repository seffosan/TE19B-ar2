using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in ålder
            Console.WriteLine("Hur gammal är du? (svara i hela antal pr)");
            int ålder = int.Parse(Console.ReadLine());

            //Om ålder = 18 skriv myndig'
            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig. DU får ta körkort.");
                // Om ålder är 15 eller högre
                if (ålder >= 15)
                Console.WriteLine("du får köra moped!");
            }
            //om åldern är lägre än 15, skriv du är för ung för att lika samtidigt som du kör moped.
            if (ålder < 15)
            {
                Console.WriteLine("du är för ung för att ligga samtidigt som du kör moped");
                
            }
            //läs in text
            Console.WriteLine("vem var statsminister i sverige 1970?");
            string statsminister = Console.ReadLine ();
            if (statsminister == "Palme" || statsminister == "palme");
            Console.WriteLine("Rätt svar!");
        

        }

        // sanera inmatningen
        statsminister = statsminister.ToLower();
        if (statsminister == "palme")
        
        console.writeline ("rätt svar!");
    }
    else {
        Console.WriteLine("Fel svar!");
}
