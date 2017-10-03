using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Levyt Cd = new Levyt();
                Cd.Nimi = "Red Hot Chili Peppers";
                Cd.Laulaja = "Anthony Kiedis";
                Cd.Malli = "CD";
                Cd.Hinta = 10;
                Cd.Biisit = 16;
                Console.WriteLine(Cd.ToString());


                Eletkroniikka Elektroniikka = new Eletkroniikka();
                Elektroniikka.Nimi = "Iphone";
                Elektroniikka.Malli = "7";
                Elektroniikka.Hinta = 800;
                Elektroniikka.Muisti = "16gp";
                Elektroniikka.Akku = "3000 mAh";
               
                Console.WriteLine(Elektroniikka.ToString());


                Kirja Book = new Kirja();
                Book.Nimi = "Aapinen";
                Book.Malli = "Opetuskirja";
                Book.Sivumäärä = 250;
                Book.Hinta = 5;
                Book.Julkaisija = "WSOY";

                Console.WriteLine(Book.ToString());
            }

        }
    }
}

