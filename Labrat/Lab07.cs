using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aleksi Manninen 10.9.2017
//Ohjelma joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä
namespace Labrat
{
    class Lab07
    {

        public static void Tehtava7()
        {
           
            Console.WriteLine("Anna vuosi:");
            int vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 400 == 0 || (vuosi % 4 == 0 && vuosi % 100 != 0))  // 400 jaollinen tai täydet neljällä jaolliset täydet vuosisadat.
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
            Console.ReadLine();










        }



    }
}
