using System;

namespace Uppgift_5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = {"vad är meningen med livet?", "LORD GIVE ME A SIGN!", "inget tecken, antar att allt bara är en bluff."};

            foreach (string mening in meningar)
            {
                Console.WriteLine(mening);
                Console.WriteLine();
            }

        }
    }
}
