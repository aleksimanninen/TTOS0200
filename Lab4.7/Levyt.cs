using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    
    
        class Levyt : Tavarat
        {
            public string Laulaja { get; set; }
            public int Biisit { get; set; }

            public Levyt()
            {

            }
        public Levyt(string nimi, string malli, int hinta, string laulaja, int biisit) : base(nimi, malli, hinta)
            {
                Laulaja = laulaja;
                Biisit = biisit;
            }
            public override string ToString()
            {
                return base.ToString() + " Laulaja: " + Laulaja + " Biisien määrä: " + Biisit;
            }
        }
}
