using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniAsio


{
    class TestaaMiniAsio
    {
        static void Testaa()
        {
            //luodaan List-Tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //testin vuoksi erilaisia tapoja lisätä oloita Listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H2451" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "B1234", Ryhmä= "TTV16S1" });
            //tai näin
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle";
            kalle.Sukunimi = "Ankka";
            kalle.AsioID = "C1234";
            kalle.Ryhmä = "TTV16S1";
            opiskelijat.Add(kalle);

            //yhden opiskelijan tietojen näyttäminen
            
            Console.WriteLine("Anna numero väliltä 1-5");
            int i = int.Parse(Console.ReadLine());

            if (i - 1 < opiskelijat.Count)
                Console.WriteLine("MiniAsion {0} opiskelija on {1}\n", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("MiniAsiossa on vain {0} opiskelijaa", i, opiskelijat.Count);

            Console.WriteLine("MiniAsion kaikki opiskelijat: ");
            foreach (var o in opiskelijat)

            {
                Console.WriteLine(o.ToString());
            }
            //KAikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaan
            opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniAsion kaikki opiskelijat: ");
            foreach (var o in opiskelijat)

            {
                Console.WriteLine(o.ToString());
            }

            //uuden opiskelijan lisääminen, huom tehdään tarkistus että asioid on uniikki
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }

            if(lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);

            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan Etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan Sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan Ryhmä");
                string ryhma = Console.ReadLine();

                //luodaan uusi Opiskelija-olio
                Opiskelija uusi = new Opiskelija(etunimi,sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniAsion kaikki {0} opiskelijaa", opiskelijat.Count);
                Console.WriteLine("MiniAsion kaikki opiskelijat: ");
                foreach (var o in opiskelijat)

                {
                    Console.WriteLine(o.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
