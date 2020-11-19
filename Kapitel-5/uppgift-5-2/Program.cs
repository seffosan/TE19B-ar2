using System;

namespace uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        /*Skapa ett program där användaren ska få skriva in en lista över alla sporter som hen har testat. Fråga först användaren hur många sporter hen vill skriva in. Därefter ska sporterna skrivas in, en efter en, på var sin rad. Slutligen ska programmet skriva ut namnen på alla sporterna som användaren skrev in. */
        {
            // fråga först användaren hur många sporter hen vill skriva in
            Console.WriteLine("hur många sporter vill du skriva in?");
            int antal = int.Parse(Console.ReadLine);

            // därefter ska sporterna skrivas in, en efter en, på var sin rad 
            string[] sporter = new string[antal];
            for (int i = 0; i < sporter.length; i++)
            {
                Console.WriteLine("skriv in någon sport");
                sporter[i] = Console.ReadLine();
            }


            // slutligen ska programmet skrivas utan namnet på alla sporterna
            Console.WriteLine("sporten du skrev in är: ");
            for (int i = 0; i < sporter.length; i++)
            {

            }

        }
    }
}
