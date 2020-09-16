/* 
Skapa ett program som frågar användaren vilket år det är, därefter ska programmet säga hur många år det är kvar till år 2100.
 */
using System;

namespace Uppgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läsa in ett årtal
            Console.Write("ange ett årtal: ");
            int årtal = int.Parse(Console.ReadLine());

            // Räkna ut antal år til 2100
            int antalÅr = 2100 - årtal;

            // skriv ut resultatet
        }
        Console.writline("antal år kvar till 2100 är " + antalÅr);
    }
}
