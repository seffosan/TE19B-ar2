using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarera variabler
            string val = "";

            // presentera en meny som visas tills användare säger stopp
            while (val != "3")
            {
                Console.WriteLine("välj något av följande val:");
                Console.WriteLine("1. addera två tal ");
                Console.WriteLine("2. multiplicera två tal ");
                Console.WriteLine("3. avsluta ");

                //lös in användarens val
                val = Console.ReadLine();

                // om val = 1
                if (val == "1")
                {
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
                }

                // om val = 2
                else if (val == "2")
                {
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double faktor1 = double.Parse(Console.ReadLine());
                    double faktor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{faktor1} * {faktor2} = {faktor1 * faktor2}");
                }
                // om val = 3
                else if (val == "3")
                {
                    Console.WriteLine("Tack för idag.");
                }
                // annars?
                else
                {
                    Console.WriteLine("Du valde inte ett giltigt alternativ.");
                }

            }
            // annars?
            switch (val)
            {
                case "1":
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");

                case "2":
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
                case "3":
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1} + {tal2} = {tal1 + tal2}");
                    break;

                default:

                    break;
            }

        }
    }
}
