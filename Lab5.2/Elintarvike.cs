using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Elintarvike
    {
        public string Nimi { get; set; }
        public string Paikka { get; set; }

        public Elintarvike()
        {
        }
        public Elintarvike(string nimi, string paikka)
        {
            Nimi = nimi;
            Paikka = paikka;
        }
        public override string ToString()
        {
            return Nimi + " paikassa " + Paikka;
        }
    }
}
