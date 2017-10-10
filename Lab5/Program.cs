using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo Audi = new Ajoneuvo("Audi", "R8", 4);
            Ajoneuvo Kawasaki = new Ajoneuvo("Kawasaki", "Z750", 2);


            Renkaat Pirelli = new Renkaat("Pirelli", "P-Zero", 20);
            Renkaat Nokia = new Renkaat("Nokia", "RS", 17);



            List<Renkaat> Tires = new List<Renkaat>();

            for (int i = 0; i < Audi.Size; i++)
            {
                Tires.Add(Pirelli);

            }
            for (int i = 0; i < Kawasaki.Size; i++)
            {
                Tires.Add(Nokia);
            }
            foreach (Renkaat item in Tires)
            {
                Console.WriteLine(item.ToString());
            }
        }     

    }
}
