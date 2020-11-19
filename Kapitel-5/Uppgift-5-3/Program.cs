using System;

namespace Uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {

          // skapa ett program som innehåller en array med minst 8 heltal
            int[] tal = {9, 45, 12, 56, 8, 9, 123, 75, 1, 46};

            // skapa en variabel som innehåller max-värdet
            int max = 0;

          // gå igenom arrayen med hjälp av en loop
            for (int i = 0; i < talen.length; i++)
            {
             // hitta det största talet i arrayen
              if (max > talen [i])
              {
                  max = talen[i];
              }
            }
          
          Console.WriteLine($"största talet är {max}");
        }
    }
}
