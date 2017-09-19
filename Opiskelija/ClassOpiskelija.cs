using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija
{
    class ClassOpiskelija

    {
        public string Nimi { get; set; }
        public string tunnus { get; set; }
        public int ikä { get; set; }
        public string sposti { get; set; }
        public string osoite { get; set; }
        public  ClassOpiskelija(string Nimi, string opiskelijatunn, int ikä, string sposti, string osoite)
            {
            this.Nimi = Nimi;
            this.tunnus = opiskelijatunn;
            this.ikä = ikä;
            this.sposti = sposti;
            this.osoite = osoite;

        }
        public ClassOpiskelija()
        {
            
        }
        public string tiedot()
        {
            return Nimi + ", " + ikä + ", " + tunnus + ", " + sposti + ", " + osoite;
        }
    }
}
