using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public class Tv
    {

        public int Kanava { get; set; }
        public int Volume { get; set; }
        public string Tila { get; set; }  //on/off??
        public string Ohjelma { get; set; }
        public void GetTila()
        {
            {
                Console.WriteLine("tv on nyt {0} .", Tila);
            }

        }

        public void GetOhjelma()
        {
            {
                Console.WriteLine("Valitsit ohjelman {0} .", Ohjelma);
            }

        }

        public void GetKanava()
            {
                Console.WriteLine("Valitsit kanavan numero {0}.", Kanava);
            }
        public void GetVolume()
            {
                Console.WriteLine("Äänenvoimakkuus on nyt {0} .", Volume);
            }


        public static void TestaaTv()
        {
            Tv uusiTv = new Tv();

            Console.WriteLine("Käynnistä Tv syöttämällä 'päällä' ");
            uusiTv.Tila = Console.ReadLine();
            uusiTv.GetTila();

            Console.WriteLine("Valitse ohjelma: Urheilu, Elokuvat, Uutiset");
            uusiTv.Ohjelma = Console.ReadLine();
            uusiTv.GetOhjelma();

            Console.WriteLine("Vaihda kanavaa. (1-10)");
            uusiTv.Kanava = int.Parse(Console.ReadLine());
            uusiTv.GetKanava();

            Console.WriteLine("Nosta tai laske äänenvoimaakkuutta (1-20)");
            uusiTv.Volume = int.Parse(Console.ReadLine());
            uusiTv.GetVolume();

        }
    }
}
