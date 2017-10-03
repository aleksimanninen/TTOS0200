using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    class Eletkroniikka : Tavarat
    {

        public string Muisti { get; set; }
        public string Akku { get; set; }

        public Eletkroniikka()
        {

        }
        public Eletkroniikka(string nimi, string malli, int hinta, string muisti, string akku):base(nimi, malli, hinta)
            {
            Muisti = muisti;
            Akku = akku;
        }
        public override string ToString()
        {
            return base.ToString() + " Muistin koko: " + Muisti + " Akku: " + Akku;
        }

    }
}
