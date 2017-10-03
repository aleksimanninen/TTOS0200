using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T6
{
    class Program
    {
        static void Main(string[] args)
        {
            KäytäRadiota();
        }

        static void KäytäRadiota()
        {

            while (true)
            {
                Radio uusiradio = new Radio();
                Console.WriteLine("Laita radio päälle syöttämällä 1");
                if (uusiradio.KäynnistäLaite(int.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("Radio on päällä.");
                }
                else
                {
                    Console.WriteLine("Radio ei ole päällä");
                    break;

                }
                Console.WriteLine("Anna volume> (0-9)");
                if (uusiradio.SäädäÄänenvoimakkuutta(int.Parse(Console.ReadLine())))
                {
                    Console.WriteLine("Volume " + uusiradio.Volume);
                }
                else
                {
                    Console.WriteLine("Ei onnistu");
                    Console.WriteLine("Volume " + uusiradio.Volume);
                }
                Console.WriteLine("Anna taajuus> (2000.0 - 26000.0)");
                if (uusiradio.SäädäTaajuutta(Convert.ToDouble(Console.ReadLine())))
                {
                    Console.WriteLine("Taajuus: " + uusiradio.Taajuus);
                }
                else
                {
                    Console.WriteLine("Väärä taajuus");
                    Console.WriteLine("Taajuus: " + uusiradio.Taajuus);
                }
                break;
            }
        }
    }
}

