using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aleksi Manninen 10.9.2017
//Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion * ** ***

namespace Labrat
{
    class Lab11
    {

        public static void Tehtava11()

        {
            int i ;
            
            Console.Write("Anna luku: ");
            i = int.Parse(Console.ReadLine());
            
            for (int b = 0; b <= i; b++)
            {
                
                for (int merkki = 0; merkki < b; merkki++)
                {
                    Console.Write("*");
                }
                
                
                    Console.Write("\n\r");
                


            }



        }






    }
}

