using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._3
{
    class Pakka : Kortti
    {
        public List<Kortti> Kortit;

        public Pakka()
        {
            Kortit = new List<Kortti>();
        }

        public override string ToString()
        {
            int numero = 1;
            string retval = "";
            foreach (Kortti item in Kortit)
            {
                retval += numero + " " + item.ToString() + "\n";
                numero++;
            }
            return retval;
        }
    }
}
