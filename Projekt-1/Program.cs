using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Är du en köttätare?");
            string köttätare = Console.ReadLine();
            köttätare = köttätare.ToLower();
            if (köttätare == "ja")
            {
                System.Console.WriteLine("planerar du på att bli en vegetarian/vegan?");
                string grönsaksätare = Console.ReadLine();
                grönsaksätare = grönsaksätare.ToLower();
                if (grönsaksätare == "ja")
                {
                    System.Console.WriteLine("bäst för dig din åsna");
                }
                if (grönsaksätare == "nej")
                {
                    System.Console.WriteLine("En dag när kossorna får större makt än människorna och börjar äta människokött, hoppas jag att du dör först.");
                }

            }
            if (köttätare == "nej")
            {
                System.Console.WriteLine("Är du en vegetarian eller vegan?");
                string vegetarian = Console.ReadLine();
                vegetarian = vegetarian.ToLower();
                if (vegetarian == "vegetarian")
                {
                    System.Console.WriteLine("bra jobbat men det är inte tillräckligt bra. BLI VEGAN!");
                }
                if (vegetarian == "vegan")
                {
                    System.Console.WriteLine("Du har redan gjort världen till en bättre plats");
                }
            }



        }
    }
}
