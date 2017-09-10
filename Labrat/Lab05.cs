using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aleksi Manninen 10.9.2017
//ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.


namespace Labrat
{
    class Lab05
    {

        public static void Tehtava5()
        {


            Console.Write("Anna sekunnit: ");
            int totalsek = Int32.Parse(Console.ReadLine());
            int sek = (totalsek % 60);
            int min = (totalsek % 3600) / 60;
            int hour = totalsek / 3600;



            Console.WriteLine(" Antamasi sekunttiaika voidaan ilmaista muodossa: " +  hour +" tuntia  " + min +" minuuttia  " + sek + " sekunttia  ");
            








        }

    }
}

