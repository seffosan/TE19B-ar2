using System;

namespace Uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // skapa en array med minst 5 heltal
            int[] talLista = new int[5] { 23, 33, 55, 66, 35 };
            // beräkna summan av alla heltal i arrayen med hjälp av en foreach-loop
            int summa = 0;
            foreach (var tal in talLista)
            {
                summa += tal;
            }

            // skriv ut summan
            Console.WriteLine($"summan är {summa}");

        }
    }
}
