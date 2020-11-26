using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa en tom array med plats för fem string
            Console.WriteLine("skriv in fem städer");

            string[] städer = new string[5];

            //fyll array, string-för-string
            for (int i = 0; i < städer.Length; i++)
            {
                städer[i] = Console.ReadLine();
            }

            //skriv ut arrayen med en foreach-loop
            foreach (string stad in städer)
            {

            }

        }
    }
}
