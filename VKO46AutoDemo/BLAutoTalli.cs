using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public static class AutoTalli
    {
        public static List<Auto> HaeAutot()
        {
            List<Auto> autot = new List<Auto>();
            //guin testaamista varten keksitään muutama auto
            Auto a = new Auto();
            a.Merkki = "Volvo";
            a.Malli = "V70";
            a.VM = 2007;
            a.KM = 200000;
            a.Hinta = 9000F;
            a.URL = "VolvoV70.png";
            autot.Add(a);

            Auto b = new Auto();
            b.Merkki = "Audi";
            b.Malli = "A4";
            b.VM = 2010;
            b.KM = 150000;
            b.Hinta = 12000F;
            b.URL = "AudiA4.png";
            autot.Add(b);

            Auto c = new Auto()
            { Merkki = "Saab", Malli = "95", VM = 1995, KM = 300000, Hinta = 750F, URL="" };
            autot.Add(c);
            

            Auto d = new Auto()
            { Merkki = "Renault", Malli = "Clio", VM = 2017, KM = 8000, Hinta = 20500F, URL="rellu.png" };
            autot.Add(d);
            return autot;
        }

    }
    public class Auto
    {
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int VM { get; set; }

        public int KM { get; set; }
        public float Hinta { get; set; }

        public string URL { get; set; }

    }
}
