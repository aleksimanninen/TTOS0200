using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aleksi Manninen 10.9.2017
//Ohjelma joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.


namespace Labrat
{
    class Lab06
    {

        public static void Tehtava6()
        {
            double kulutus = 7.02;
            double bensa = 1.595;
            double kustannus;
            double hinta;
            double matka;

            Console.Write("Anna Matka: ");
            matka = Int32.Parse(Console.ReadLine());

            kustannus = (matka / 100) * kulutus;
            hinta = kustannus * bensa;



            Console.WriteLine(" Bensaa kuluu " + kustannus + "kustannus " + hinta + " euroa");









        }

    }
}


 

