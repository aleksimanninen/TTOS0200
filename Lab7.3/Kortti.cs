using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._3
{
    class Kortti
    {
        public string Maa { get; set; }
        public int Arvo { get; set; }

        public Kortti()
        {

        }
        public Kortti(string maa, int luku)
        {
            Maa = maa;
            Arvo = luku;
        }
        public override string ToString()
        {
            return "Kortti on " + Maa + "#" + Arvo;


        }
    }
}
