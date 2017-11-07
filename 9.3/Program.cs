using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalastaja tyyppi = new Kalastaja("Kirsi Kernel", "020-12345678");
            tyyppi.GotFish(new Kala("Ahven", 35, 2.9, "Jyväs-Järvi"));
            tyyppi.GotFish(new Kala("Hauki", 50, 5.0, "Päijänne"));
            tyyppi.GotFish(new Kala("Lohi", 95, 8.9, "Tenojoki"));
            tyyppi.GotFish(new Kala("Tonnikala", 8, 0.2, "Itämeri"));


            Console.WriteLine("\nKaikki kalat rekisterissä:");
            Console.WriteLine("\nKalajasta {0} on saanut seuraavat kalat:", tyyppi.Nimi);
            tyyppi.PrintList();
            Console.WriteLine("\nKaikki kalat suuruus järjetyksessä:");
            tyyppi.Sortedlist();
           






        }

       

        
      
    }

}

 
