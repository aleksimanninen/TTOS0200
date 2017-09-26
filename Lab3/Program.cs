using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   //Aleksi Manninen 26.9.2017
    
    class Program
        {
            static void Main(string[] args)
            {
             testaaPvm();
             testaaLuku();
            }
            static void testaaLuku()
            {
                Console.WriteLine("Anna testattava teksti");
                string teksti = Console.ReadLine();
                Luku.OnkoLuku(teksti);
            }
            static void testaaPvm()
            {
                Console.WriteLine("Anna testattava päivämäärä");
                string paivamaara = Console.ReadLine();
                Luku.OnkoPvm(paivamaara);
            }
        }
    }


