using System;

namespace Uppgift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Skapa ett program där användaren ska få skriva in åldern på personerna i ett hyreshus. Programmet ska först fråga användaren om en ålder. Därefter ska programmet fråga om användaren vill skriva in en till ålder och förvänta sig svaret "j" eller "n". Användaren ska få fortsätta skriva in nya åldrar tills hen svarar "n". Skriv därefter ut alla åldrar som användaren skrev in.

           Programmet ska tillåta användaren att skriva in upp till 100 åldrar utan att krascha, om användaren har skrivit in 100 åldrar ska programmet skriva ut "Programmet har inte plats för fler åldrar" och därefter skriva ut alla åldrar som har sparats.*/

            // Programmet ska först fråga användaren om en ålder
            Console.WriteLine("Skriv in en eller flera åldrar (max 100).");


            // programmet ska tillåter användaren att  skriva in upp till 100 åldrar
            int [] ålder = new int[100];

            //upprepa inmatning = loop
            for (int i = 0; i < ålder.length; i++)
            {
                
            }

            // därefter ska programmet fråga om användaren vill skriva in en till ålder och förvänta sig svaret "j" eller "n"
            Console.WriteLine("vill du skriva ner en till ålder?");
            ålder = Console.ReadLine()
        // om användaren har skrivit in 100 åldrar ska programmet skriva ut "programmet har inte plats för fler åldrar"

            // programmet ska skriva ut alla åldrar som har sparats.
        }
    }
}
