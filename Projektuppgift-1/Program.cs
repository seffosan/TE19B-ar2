using System;

namespace Projektuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {// Skriv välkomstmeddelande
            Console.WriteLine("Hej och välkommen till Sefs magiska spel!");

            // Sätt menyVal till "0"
            string menyVal = "0";
            while (menyVal != "4") ;

            {

            }
            // while (menyval != ”4”)

            // Skriv ut meny
            Console.WriteLine("vad väntar du på? VÄLJ ETT ALTERNATIV!!!");
            Console.WriteLine("1. Spela 21an. det är inte basket om det var det du trodde hahahahahaha.");
            Console.WriteLine("2. visa senaste den senaste vinnaren. titta i spegeln om du vill se den senaste förloraren.");
            Console.WriteLine("3. Spelets regler (inte för att man ska följa de. valet finns bara för dekoration).");
            Console.WriteLine("4. avsluta programmet, som ditt ex avslutade dig.");
            menyVal = Console.ReadLine();
            // Läs in menyValjhh

            // switch menyVal
            // case 1: Spela en omgång av 21:an
            // case 2: Visa senaste vinnaren
            // case 3: Visa spelets regler
            // case 4: Gör ingenting (programmet avslutas)
            // default: Skriv att alternativet var ogiltigt

        }
    }
}
