using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    //Aleksi Manninen 26.9.2017
    class Vahvari
    {
        private readonly int Maxvolume = 100;
        private readonly int Minvolume = 0;

        private int volume; // jos public näkyy olion ulkopuolelle
        public int Volume // muuttuja sekä property eli ominaisuus koska get set
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= Maxvolume && value >= Minvolume) volume = value;
                else if (value > Maxvolume)
                {
                    Console.WriteLine("Max volume = 100, asetetaan maksimiin.");
                    volume = Maxvolume;
                }
                else if (value < Minvolume)
                {
                    Console.WriteLine("Min volume = 0, asetetaan minimiin.");
                    volume = Minvolume;
                }
            }
        }
    }

        class TestaaVahvari         //kapselointia alempana!!
        {
        static void Main(string[] args)
          {
            Vahvari sony = new Vahvari();  
            sony.Volume = 50;
            Console.WriteLine(sony.Volume);
            sony.Volume = 101;
            Console.WriteLine(sony.Volume);
          }

        }

}
