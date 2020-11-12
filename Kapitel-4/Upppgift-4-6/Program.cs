using System;

namespace Uppgift_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string meddelande = "Detta är kanske ett meddelande. beror på om den här jäveln har kodat rätt eller inte.";

            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }

        }
    }
}