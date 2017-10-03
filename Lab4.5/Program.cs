using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {


            Polkupyörä Trek = new Polkupyörä("Trek", "ML17", 2017, "Punainen", "3x8", "Shimano XTR");
            Polkupyörä Helkama = new Polkupyörä("Helkama", "Jopo", 1999, "Musta", "1", "-");

            Console.WriteLine(Trek.ToString());
            Console.WriteLine(Helkama.ToString());

            Vene Bayliner = new Vene("Bayliner", "xl", 2015, "Valkoinen", "Moottorivene", 8);
            Vene Buster = new Vene("Buster", "xs", 2001 , "Keltainen", "Kalavene", 4);

            Console.WriteLine(Bayliner.ToString());
            Console.WriteLine(Buster.ToString());

        }    
    }
}
