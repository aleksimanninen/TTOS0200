using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Aleksi Mannninen 10.9.2017
//Ohjelma joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
namespace Labrat
{
    class Lab09
    {
       
        public static void Tehtava9()
             
        {
            {
                int luku;
                int sum = 0;
                while(true)
                {
                    Console.Write("Anna Luku: ");
                     luku = int.Parse(System.Console.ReadLine());
                    
                    if (luku == 0)  // jos 0 katkeaa
                    {
                        break;
                    }
                    else if (luku != 0) // jos eri kuin 0 laskee summaa taustalla
                    {
                        sum = sum + luku;
                        continue;
                    }
                    
                }
                Console.WriteLine("Lukujen summa on: " + sum);
            } 
                    
        }
    }



          

          


}

