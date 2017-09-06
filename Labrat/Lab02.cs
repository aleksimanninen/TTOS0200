using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aleksi Manninen 6.9.2017
/*Ohjelma jossa annetaan oppilaalle koulunumero
seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)*/

namespace Labrat
{
    class Lab02
    {

        public static void Tehtava2()
        {


            int luku;
            Console.Write("Anna pistemäärä > ");
            luku = int.Parse(Console.ReadLine());

            if (luku >= 0 && luku <= 1)
            {

                Console.WriteLine("Koulunumero on 0");
            }

            else if (luku >= 2 && luku <= 3)
                Console.WriteLine("Koulunumero on 1");

            else if (luku >= 4 && luku <= 5)
                Console.WriteLine("Koulunumero on 2");

            else if (luku >= 6 && luku <= 7)
                Console.WriteLine("Koulunumero on 3");

            else if (luku >= 8 && luku <= 9)
                Console.WriteLine("Koulunumero on 4");

            else if (luku >= 10 && luku <= 12)
                Console.WriteLine("Koulunumero on 5");

            Console.ReadLine();






        }



    }
}