using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04T6
{
    class Radio
    {
        private readonly int Virta = 1;
        private readonly int Maxvolume = 9;
        private readonly int Minvolume = 0;

        private readonly double Maxtaajuus = 26000.0;
        private readonly double Mintaajuus = 2000.0;

        private double taajuus;
        private int volume;
        private int virta;

        public bool KäynnistäLaite(int luku)
        {
            if (luku == Virta)
            {
                virta = luku;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SäädäÄänenvoimakkuutta(int arvo)
        {
            if (arvo <= Maxvolume && arvo >= Minvolume)
            {
                volume = arvo;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SäädäTaajuutta(double hz)
        {
            if (hz <= Maxtaajuus && hz >= Mintaajuus)
            {
                taajuus = hz;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {

            }
        }
        public double Taajuus
        {
            get
            {
                return taajuus;
            }
            set
            {

            }
        }


    }
}