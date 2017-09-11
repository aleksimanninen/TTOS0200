using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aleksi Manninen 11.9.2017
//Ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten,
// että summasta on vähennetty pois pienin ja suurin tyylipiste.
namespace Labrat
{
    class Lab13
    {

        public static void Tehtava13()
        {


            int[] num = new int[5]; // alustetaan taulukko 5 luvulle
            int sum;
            
            
            for (int i = 0; i<num.Length; i++)
            
            {
                Console.WriteLine("Anna pisteet");
                num[i] = int.Parse(System.Console.ReadLine());
              
            }
           

            Array.Sort(num);
            sum = num[1] + num[2] + num[3];  // Jättää pois isoimman ja pienemmän arvon
            System.Console.WriteLine("Pisteet ovat: " +sum);



            Console.ReadLine();
        }
    }
}
