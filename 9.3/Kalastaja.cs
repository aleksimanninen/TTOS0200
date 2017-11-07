using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._3
{
    class Kalastaja
    {
        public string Nimi { get; set; }
        string Numero { get; set; }
        List<Kala> Kalat = new List<Kala>();
        public Kalastaja(string nimi, string numero)
        {
            Nimi = nimi;
            Numero = numero;
            Console.WriteLine("\n Uusi kalastaja lisättiin rekisteriin:");
            Console.WriteLine(" - Kalastaja: " + Nimi + " Puh.num: " + Numero);
        }
        public void GotFish(Kala kala)
        {
            Kalat.Add(kala);
            Console.WriteLine("\n Kalastaja : {0} sai uuden kalan > \n{1}", Nimi, kala.ToString());

        }

        public void Sortedlist()
        {
            Kalat.Sort((x, y) => y.Paino.CompareTo(x.Paino));
            PrintList();

        }

        public void PrintList()
        {
            foreach (Kala kala in Kalat) Console.WriteLine(kala);
        }
    }

}
