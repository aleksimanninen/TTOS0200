using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Ihminen : Nisäkäs
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public override void Liiku()
        {
            Console.WriteLine("Liikkuu");
        }
        public void Kasvu()
        {
            Ikä++;
        }
        public override string ToString()
        {
            return "Nimi:" + Nimi + " Paino:" + Paino + " Pituus:" + Pituus;
        }
 }    }
