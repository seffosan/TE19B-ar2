using System;

namespace Uppgift_1_lyckojhul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("välj ett tal mellan 1-10");
            int gissning = int.Parse(Console.ReadLine());

            Random slumpa = new Random();
            int oväntat = slumpa.Next(1, 11);

            if (oväntat == gissning)
            {
                Console.WriteLine("Grattis på födelsedagen!");
            }
            else
            {
                Console.WriteLine("type dotnet run and try again moda sokka. the ansa is " + oväntat);
            }
        }
    }
}
