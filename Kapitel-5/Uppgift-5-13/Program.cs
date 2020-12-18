using System;

namespace Uppgift_5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] labyrint = {
                {1, 1, 1, 1, 1},
                {0, 0, 0, 0, 1},
                {1, 0, 1, 0, 1},
                {1, 0, 1, 0, 0},
                {1, 0, 1, 1, 1},
            };

            //för att skriva ut UTF-tecken
            Console.OutputEncoding = System.Text.Encoding.Default;

            //loopa igenom raderna 0-4
            for (int y = 0; y < 5; y++)
            {
                //loopa igenom cellerna o-4
                for (int x = 0; x < 5; x++)
                {
                    //om i skriv ut vit fyrkant, annars svart fyrkant
                    if (labyrint[y, x] == 1)
                    {
                        Console.Write('\u2B1C');
                    } else
                    {
                        Console.Write('\u2B1B');
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
