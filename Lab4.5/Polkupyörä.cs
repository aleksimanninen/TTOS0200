using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Polkupyörä : Ajoneuvo

    {
        public string Vaihdelkm { get; set; }
        public string Vaihdemalli { get; set; }

        public Polkupyörä()
        {

        }
        public Polkupyörä(string nimi, string malli, int vuosimalli, string väri, string vaihdelkm, string vaihdemalli)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;
            Vaihdelkm = vaihdelkm;
            Vaihdemalli = vaihdemalli;
        }
        public override string ToString()
        {
            return "Tiedot" + "\n" + "Nimi : " + Nimi + " " + "Malli: " + Malli + " " + "Vuosimalli: " + Vuosimalli + " " + "Väri: " + Väri + " " + "Vaihdetyyppi: " + Vaihdelkm + " " + "Vaihdemalli: " + Vaihdemalli + "\n";
        }
    }
}
