using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aleksi Manninen 11.9.2017
//Ohjelma joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
// Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
namespace Labrat
{
    class Lab12
    {

        public static void Tehtava12()
        {
            
 
            int[] num = new int[5]; // alustetaan taulukko 5 luvulle


            for (int i = 0; i < 5; i++)    // kysyy 5 lukua
            {

                Console.WriteLine("Anna luku");
                num[i] = int.Parse(System.Console.ReadLine());
            }
                for (int b = 4; b > -1; b--)                //b-- kääntää jonon
                {
                    Console.Write( " " + num[b] + " ");
                }

            Console.ReadLine();
        }
    }
}

