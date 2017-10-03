using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    class Kirja : Tavarat
    {
        public int Sivumäärä { get; set; }
        public string Julkaisija { get; set; }

        public Kirja()
        {

        }
        public Kirja(string nimi, string malli, int hinta, int sivumäärä, string julkaisija) : base(nimi, malli, hinta)
            {
            Sivumäärä = sivumäärä;
            Julkaisija = julkaisija;
        }
        public override string ToString()
        {
            return base.ToString() + " Sivumäärä: " + Sivumäärä + " Julkaisija: " + Julkaisija;
        }
    }
}
