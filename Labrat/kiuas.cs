using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
     public class Kiuas
    {
        public int Lämpötila { get; set; }
        public int Kosteus { get; set; }
        public string Tila { get; set; }  //on/off??
        public void GetTila()
        {
            {
                Console.WriteLine("Kiuas on nyt {0} .", Tila);
            }

        }
        public void GetLämpötila()
        {
            Console.WriteLine("Kiukaan lämpötila on {0} astetta.", Lämpötila);
        }
        public void GetKosteus()
        {
            Console.WriteLine("Heitit löylyä {0} kertaa.", Kosteus);
        }



         public static void TestaaKiuas()
        {
            Kiuas uusiKiuas = new Kiuas();

            Console.WriteLine("Onko kiuas päällä/kiinni?(vastaa päällä tai kiinni)");
            uusiKiuas.Tila = Console.ReadLine();
            uusiKiuas.GetTila();
            
            Console.WriteLine("Aseta lämpötila");
            uusiKiuas.Lämpötila = int.Parse(Console.ReadLine());
            uusiKiuas.GetLämpötila();

            Console.WriteLine("Heitä löylyä x kertaa");
            uusiKiuas.Kosteus = int.Parse(Console.ReadLine());
            uusiKiuas.GetKosteus();
        }
    }

    


}
