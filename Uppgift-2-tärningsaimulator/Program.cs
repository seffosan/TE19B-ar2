using System;

namespace Uppgift_2_tärningsaimulator
{
    class Program
    {
        static void Main(string[] args)
        {   //Fråga hur  många gånger tärningen skall kastas.
            Console.WriteLine("hur mågna tärningar vill du kasta?");
            int kast = int.Parse(Console.ReadLine());

            //Fråga hur många sidor varje tärning ska ha.
            Console.WriteLine("hur många sidor vill du att din tärning ska ha?");
            int sidor = int.Parse(Console.ReadLine());

            //Kasta tärningen ett antal gånger.
            Random tärning = new Random();
            
            
            //för varje kast kan man ett slumptal med så många sidor.
            //skriv ut varje kast.
        }
    }

}
