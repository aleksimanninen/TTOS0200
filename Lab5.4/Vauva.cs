using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Vauva : Ihminen
    {
        
        
            public string Vaippa { get; set; }

            public override void Liiku()
            {
                Console.WriteLine("Konttaa");
            }
            public override string ToString()
            {
                return base.ToString() + " Ikä:"  + Ikä + " Vaippa:" + Vaippa ;
            }
       

    }    
}
