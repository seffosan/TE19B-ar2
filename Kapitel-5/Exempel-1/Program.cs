using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
          //alt 1: Här skapar vi en array på tre strings  
         //skapa en array av tre städer: "Stockholm", "Paris", "London"
         string[] städer = {"Stockholm", "Paris", "London"}; //låst till 3!

        // skriver ut innehållet
        // städer[0] = "Stockholm"; // index = 0
        // Städer[1] = "Paris";     // index = 1
        // Städer[2] = "London";    // index = 2

        //alt 2: Skapa en tom array på strings
        string[] länder = new string [2];

        //skapa en annan array av tre tal
        int[] årtal = new int[3];

        // fylla en array 
        länder [0] = Frankrike;
        länder [1] = Polen;
        årtal[0] = 1945
        årtal[1] = 1975
        årtal[2] = 2000

        // skriv ut alla årtalen i arrayen årtal
        for (int i = 0; i < 3;  i++) // .length = antalet = 3
        {
            console.writeline(årtal[i]); // årtal [0], årtal[1], årtal[2]
        }
            
        }
    }
}
