using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Joukkue Jyp = new Joukkue();
            Jyp.Name = "Jyp";
            Jyp.Kaupunki = " Jyväskylä";
            Jyp.pelaajat.Add(new Pelaaja("Jani Tuppurainen", "Hyökkääjä", "Left"));
            Jyp.pelaajat.Add(new Pelaaja("J-P Hytönen", "Hyökkääjä", "Left"));
            Jyp.pelaajat.Add(new Pelaaja("Nolan Yonkman", "Puollustaja", "Right"));

            Joukkue Kalpa = new Joukkue();
            Kalpa.Name = "Kalpa";
            Kalpa.Kaupunki = " Kuopio";
            Kalpa.pelaajat.Add(new Pelaaja("Santeri Lukka", "Puollustaja", "Right"));
            Kalpa.pelaajat.Add(new Pelaaja("Mikko Nuutinen", "Hyökkääjä", "Right"));
            Kalpa.pelaajat.Add(new Pelaaja("Alexander Ruuttu", "Hyökkääjä", "Right"));



            Console.WriteLine("Kumman seuran pelaajatiedot haluat tulostaa(valitse numerolla) \n 1.Jyp \n 2.Kalpa \n ");
            int valinta = int.Parse(Console.ReadLine());
            if (valinta == 1)
            {
                Console.WriteLine(Jyp.ToString());
            }
            else if (valinta == 2)
            {
                Console.WriteLine(Kalpa.ToString());
            }
            else
            {
                Console.WriteLine("Kokeile uusiks");
            }
        }
    }
}
