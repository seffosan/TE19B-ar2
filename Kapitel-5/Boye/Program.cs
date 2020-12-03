using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
        // lagra dikten i en array
        string[] dikt = {
        "Den mätta dagen, den är aldrig störst.",
        "Den bästa dagen är en dag av törst.",
        "Nog finns det mål och mening i vår färd,",
        "men det är vägen, som är mödan värd.",
        "Det bästa målet är en nattlång rast,",
        "där elden tänds och brödet bryts i hast.",
        "På ställen, där man sover blott en gång,",
        "blir sömnen trygg och drömmen full av sång.",
        "Bryt upp, bryt upp! Den nya dagen gryr.",
        "Oändligt är vårt stora äventyr",};


        //skriv ut dikten
        //loopa igenom arrayen
        foreach (var rad in dikt)

        {
        System.Console.WriteLine(rad);
        }
        }
    } 
        //skriv som verser
        //loopar igenom arrayen
        for (int i = 0; i < dikt.length; i++)
        {
           if (i % 2 == 0)
           {
               System.Console.WriteLine(rad[i]);
           }
           else
           {
               System.Console.WriteLine(rad[i] + "/n");
           }
           //dela upp raden i ord i en array av ord
           dikt[i].split(' ');
            // räkna orden: antal ord i arrayen
            int antalOrd = orden.Length;
            //addera till total antal ord
            System.Console.WriteLine($"antal ord i dikten är{totalAntalOrd}");
        }


}
