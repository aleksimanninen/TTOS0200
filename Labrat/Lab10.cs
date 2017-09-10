using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Aleksi Manninen 10.9.2017
//Ohjelma joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100].
namespace Labrat
{
    class Lab10
    {
        public static void Tehtava10()

        {
            

            int[] luvut = new int[] { 1, 2, 33, 44, 55, 68, 77, 98, 100 };

            for (int i = 0; i < luvut.Length; i++)
            {

                if (luvut[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
                else if (luvut[i] % 2 != 0)
                {
                    Console.WriteLine("*"); 
                }

                
            }
                


        }






    }

}