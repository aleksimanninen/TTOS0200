﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3
{


    class Kala
    {
        string Laji { get; set; }
        int Pituus { get; set; }
        public float Paino { get; set; }
        string Paikka { get; set; }


        public Kala(string laji, int pituus, float paino, string paikka)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            Paikka = paikka;

        }
        public override string ToString()
        {
            return "\n - Laji : " + Laji + " " + Pituus + " cm " + Paino + " kg  " + Paikka;
        }

    }
      
}

