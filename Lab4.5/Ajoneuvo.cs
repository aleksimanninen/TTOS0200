using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Ajoneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosimalli { get; set; }
        public string Väri { get; set; }

        public Ajoneuvo()
        {

        }
        public Ajoneuvo(string nimi, string malli, int vuosimalli, string väri)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;
        }
    }
}

