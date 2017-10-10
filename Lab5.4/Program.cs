using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Aikuinen Mies = new Aikuinen();
            Mies.Nimi = "Mikko";
            Mies.Ikä = 24;
            Mies.Pituus = 185;
            Mies.Paino = 85;
            Mies.Auto = "Audi";
            Console.WriteLine(Mies.ToString());
            Mies.Kasvu();
            Mies.Liiku();
            Mies.Kasvu();
            Mies.Liiku();
            Console.WriteLine("Miehen ikä:" + Mies.Ikä);

            Vauva Baby = new Vauva();
            Baby.Nimi = "Teppo";
            Baby.Ikä = 2;
            Baby.Pituus = 60;
            Baby.Paino = 15;
            Baby.Vaippa = " Check";
            Console.WriteLine(Baby.ToString());
            Baby.Kasvu();
            Baby.Kasvu();
            Baby.Liiku();
            Baby.Liiku();
            Console.WriteLine("Vauvan ikä:" + Baby.Ikä);

            Ihminen Markus = new Ihminen();
            Markus.Nimi = "Markus";
            Markus.Ikä = 27;
            Markus.Pituus = 180;
            Markus.Paino = 75;
            Console.WriteLine(Markus.ToString());
            Markus.Liiku();
            Markus.Liiku();


        }
    }
}
