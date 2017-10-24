using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Biisi
    {
         
        string Nimi { get; set; }
        string Pituus { get; set; }

        public Biisi()
        {

        }
        public Biisi(string nimi, string pituus)
        {
            Nimi = nimi;
            Pituus = pituus;
        }

        public override string ToString()
        {
            return Nimi + ", " + Pituus;
        }

    }
}
