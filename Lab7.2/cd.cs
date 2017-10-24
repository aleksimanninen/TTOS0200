using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Cd : Biisi
    {
        public string Name { get; set; }
        public string Artisti { get; set; }
        public List<Biisi> Biisit;

        public Cd()
        {
            Biisit = new List<Biisi>();
        }
        public override string ToString()
        {
            string retval = "CD data:" + "\n -Nimi: " + Name + "\n -Artisti: " + Artisti + "\n -Biisit: \n";
            foreach (Biisi item in Biisit)
            {
                retval += "  -" + item.ToString() + "\n";
            }
            return retval;
        }
    }
}
