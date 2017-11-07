using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
  
        class Product
        {
            string Nimi { get; set; }
            double Hinta { get; set; }
            public Product(string nimi, double hinta)
            {
                Nimi = nimi;
                Hinta = hinta;
            }
            public override string ToString()
            {
                return " -product: "+ Nimi + " "+ Hinta + " $";
            }

        }
    
}
