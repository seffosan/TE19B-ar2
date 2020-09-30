using System;

namespace Uppgift_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vem vann fotbolls-vm för damer 2015 ? ");
            string vinnare = Console.ReadLine();

            // sanera inmatningen
            vinnare = vinnare.ToLower();

            // kontrollera om rätt svar
            if (vinnare == "usa");
            Console.WriteLine("rätt svar!");

            else {
                Console.WriteLine ("Fel svar!");
            }

            
        }
    }
}
