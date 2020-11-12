using System;

namespace Prov_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            //presentation
            Console.WriteLine("det här programmet räknar ut din lön, sk nettolön, efter marginalskatten. /n" +
            "marginalskatten räknas ut beroende på din bruttolön./n" +
            "med bruttolön avses din årslön före skatt" );

            //först matar användaren in sin bruttolön
            Console.WriteLine("ange din bruttolön i kronor.");
            
            //översätt från sträng till heltal
            int bruttolön = int.Parse(bruttolönsträng);

            //därefter räknas marginalskatten
            int marginalskatt = 8;
            else if (bruttolön < 145000)
            {
                marginalskatt = 22;
            }
            else if (bruttolön < 515000)
            {
                marginalskatt = 33;
            }
            else
            {
                marginalskatt = 53;
            }
            //sen räknas nettolönen ut
            //nettolön=bruttolön * (100-marginalskatt) / 100
            }
            int nettolön=bruttolön * (100-marginalskatt) / 100;

            //nettolön presenteras för användaren
            

        }
    }
}
