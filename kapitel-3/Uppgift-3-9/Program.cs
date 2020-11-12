using System;

namespace Uppgift_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Be användaren mata in sin plats i turneringen
            Console.WriteLine("Vilken plats kom du i den senaste idrottsturneringen du var med på? (svara mellan 1-20");
            int plats = int.Parse(Console.ReadLine());

            // Säga vilken medalj det blir
            if (plats == 1)
            {
                Console.WriteLine("Grattis! du har fått en guldmedalj");
            }
            else if (plats == 2)
            {
                Console.WriteLine("du får din dumma silvermedalj din andraplats jävel");
            }

            else if (plats == 3)
            {
                Console.WriteLine("waw. av alla sämsta spelare var du den bästa. du får en bronsmedalj");
            }

            else
            {
                Console.WriteLine("vad gör du ens här? du såg 3 pers framför dig och du trodde du skulle få en medalj? hejdå!");
            }
            // 1 = guld 2 = silver 3 = brons och 4 och högre = ingen medalj



        }
        
            
        
    }
}
