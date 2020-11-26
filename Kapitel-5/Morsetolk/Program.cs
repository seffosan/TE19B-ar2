using System;

namespace Morsetolk
{
    class Program
    {
        static void Main(string[] args)
        {
            //berätta om programmet
            //be om ett meddelande
            Console.WriteLine("det här programmet översätter svensk morsekod.");
            System.Console.WriteLine("ange ett meddelande: ");
            string meddelande = Console.ReadLine();


            //loopa igenom meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                //skriv ut varje tecken 
                string bokstav = meddelande[i].ToString();
                Console.WriteLine($"{bokstav}");
                //översätt bokstav till morsekod
                //skapa en samling för alfabetet (string)
                string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

                //hitta bokstavens plats i alfabetet
                int index = alfabetet.IndexOf(bokstav);

                // vart fanns bokstaven?
                Console.WriteLine($"{bokstav} finns på position {index}");

                //skapa en samling för morsek
                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", "" };
                //loopa igenom meddelandet
                string morseMeddelande = "";
                for (int i = 0; i < meddelande.length; i++)
                {
                    Console.WriteLine($"{morse[0]} {morse[20]}");

                    //skriv ut morsekoden för bokstaven
                    string morseBokstav = morse[index];
                    Console.WriteLine($"{bokstav}'s morsekod är {morseBokstav}");

                    //samla in hela meddelandet i morsekod
                    morseMeddelande += morseBokstav;
                }
                //skriv ut hela meddelandet i morsekod
                Console.Write(morsemeddelande);

            }




        }
    }
}
