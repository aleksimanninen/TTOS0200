using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aleksi Manninen 6.9.2017
/* ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen",
 * jos se on 18-65 vuotta,
   tulosta "aikuinen", muussa tapauksessa tulosta "seniori".*/

namespace Labrat
{
    class Lab04
    {
        public static void Tehtava3()
        {
            

            Console.Write("Anna Ikäsi: ");
            int ikä = Int32.Parse(Console.ReadLine());


            if (ikä >= 0 && ikä <= 18)
            {

                Console.WriteLine("Alaikäinen");
            }


            else if (ikä >= 18 && ikä <= 65)
                {

                    Console.WriteLine("aikuinen");
                }

            else if (ikä < 65 )
            {

                 Console.WriteLine("Seniori");
            }




        }

        }
}
