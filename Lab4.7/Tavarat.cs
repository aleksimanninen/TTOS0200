using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    
    
        class Tavarat
        {
            public string Nimi { get; set; }
            public string Malli { get; set; }
            public int Hinta { get; set; }
            

            public Tavarat()
            {
            }
            public Tavarat(string nimi, string malli, int hinta)
            {
                Nimi = nimi;
                Malli = malli;
                Hinta = hinta;
                
            }
            public override string ToString()
            {
            return  "Nimi: " + Nimi + " Malli: " + Malli + " Hinta: " + Hinta;
            }

        }
}
