using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
   public class Opiskelija
    {
        string Nimi { get; set; }
        int Ikä { get; set; }

        string AsioID { get; set; }

        string Ryhmä { get; set; }
        public static int Oplkm = 0;
        public Opiskelija(string nimi, int ikä,string asioid,string ryhma)
        {
            Nimi = nimi;
            Ikä = ikä;
            AsioID = asioid;
            Ryhmä = ryhma;
            Oplkm++;
        }
        public static int Montako()
        {
            return Oplkm;
        }

        public override string ToString()
        {
            return "--Opiskelijan nimi: " + Nimi + " ,Ikä " + Ikä + ", AsioID: " + AsioID + ". Kuuluu Ryhmään: " + Ryhmä;
        }
    }
}
