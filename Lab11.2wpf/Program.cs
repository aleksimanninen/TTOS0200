using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{

    public static class Joukkue
    {
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> lista = new List<Pelaaja>();
            lista.Add(new Pelaaja("Jani", "Tuppurainen", "Hyökkääjä", "Left" ,20));
            lista.Add(new Pelaaja("J-P", "Hytönen", "Hyökkääjä", "Left",10));
            lista.Add(new Pelaaja("Nolan", "Yonkman", "Puolustaja", "Right", 8));
            lista.Add(new Pelaaja("Jani", "Tuppurainen", "Hyökkääjä", "Left", 20));
            lista.Add(new Pelaaja("J-P", "Hytönen", "Hyökkääjä", "Left", 10));
            lista.Add(new Pelaaja("Nolan", "Yonkman", "Puolustaja", "Right", 8));
            lista.Add(new Pelaaja("Jani", "Tuppurainen", "Hyökkääjä", "Left", 20));
            lista.Add(new Pelaaja("J-P", "Hytönen", "Hyökkääjä", "Left", 10));
            lista.Add(new Pelaaja("Nolan", "Yonkman", "Puolustaja", "Right", 8));
          
            return lista;
        }
    }
        public class Pelaaja
        {
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string Pelipaikka { get; set; }
            public string Katisyys { get; set; }
            public double Numero { get; set; }

            public Pelaaja(string etunimi, string sukunimi,string pelipaikka, string katisyys, double numero)
            {
                this.Etunimi = etunimi;
                this.Sukunimi = sukunimi;
                this.Pelipaikka = pelipaikka;
                this.Katisyys = katisyys;
                this.Numero = numero;
            }


        }

               
        
    
}
