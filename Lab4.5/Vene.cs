﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{

    class Vene : Ajoneuvo
    {
        public string Tyyppi { get; set; }
        public int Istuimet { get; set; }

        public Vene()
        {

        }

        public Vene(string nimi, string malli, int vuosimalli, string väri, string tyyppi, int istuimet)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosimalli = vuosimalli;
            Väri = väri;
            Tyyppi = tyyppi;
            Istuimet = istuimet;
        }
        public override string ToString()
        {
            return "Tiedot" + "\n" + "Nimi : " + Nimi + " " + "Malli: " + Malli + " " + "Vuosimalli: " + Vuosimalli + " " + "Väri: " + Väri + " " + "Tyyppi: " + Tyyppi + " " + "Istuimet: " + Istuimet + "\n";
        }

    }
 }
