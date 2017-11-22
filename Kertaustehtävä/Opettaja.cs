using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    public class Opettaja
    {
        string Nimi { get; set; }
        int Ikä { get; set; }
        double Puh { get; set; }

        public Opettaja(string nimi, int ikä,double puh)
        {
            Nimi = nimi;
            Ikä = ikä;
            Puh = puh;
        }

        public override string ToString()
        {
            return "--Opettajan nimi: " + Nimi + "\n             Ikä: " + Ikä + "\n         Puh.Num: " + Puh;
        }
    }
}
