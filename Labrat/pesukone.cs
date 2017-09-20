using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
     public class Pesukone
    {

        public int Lämpötila { get; set; }
        public int Linkous { get; set; }
        public string Tila { get; set; }  //on/off??
        public string Ohjelma { get; set; }
        public void GetTila()
        {
            {
                Console.WriteLine("Pesukone on nyt {0} .", Tila);
            }

        }

        public void GetOhjelma()
        {
            {
                Console.WriteLine("Valitsemasi pesuohjelma on {0}  .", Ohjelma);
            }

        }


        public void GetLämpötila()
        {
            Console.WriteLine("Veden lämpötila on {0} astetta.", Lämpötila);
        }
        public void GetLinkous()
        {
            Console.WriteLine("Linkouksen nopeus on {0} .", Linkous);
        }


         public static void TestaaPesukone()
        {
            Pesukone uusipesukone = new Pesukone();

            Console.WriteLine("Käynnistä pesukone syöttämällä 'päällä' ");
            uusipesukone.Tila = Console.ReadLine();
            uusipesukone.GetTila();

            Console.WriteLine("Valitse ohjelma: Käsipesu, pikapesu vai hienopesu");
            uusipesukone.Ohjelma = Console.ReadLine();
            uusipesukone.GetOhjelma();

            Console.WriteLine("Valitse veden lämpötila. 30/40/60");
            uusipesukone.Lämpötila = int.Parse(Console.ReadLine());
            uusipesukone.GetLämpötila();

            Console.WriteLine("Valitse linkousnopeus. 600 / 800 / 1200");
            uusipesukone.Linkous = int.Parse(Console.ReadLine());
            uusipesukone.GetLinkous();

        }
    }
}
