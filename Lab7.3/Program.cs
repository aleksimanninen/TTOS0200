using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pakka Muovipakka = new Pakka();

            for (int i = 1; i < 14; i++)
            {
                Muovipakka.Kortit.Add(new Kortti("Pata", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Muovipakka.Kortit.Add(new Kortti("Risti", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Muovipakka.Kortit.Add(new Kortti("Hertta", i));
            }
            for (int i = 1; i < 14; i++)
            {
                Muovipakka.Kortit.Add(new Kortti("Ruutu", i));
            }
            for (int i = 1; i < 3; i++)
            {
                Muovipakka.Kortit.Add(new Kortti("Jokeri", i));
            }


            Console.WriteLine(Muovipakka.ToString());
        }
    }
}
