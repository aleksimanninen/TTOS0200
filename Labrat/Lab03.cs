using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aleksi Manninen 6.9.2017
//Ohjelma joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.


namespace Labrat
{
    class Lab03
    {

        public static void Tehtava3()
        {
            {

                
                Console.Write("Anna numero: ");
                int num = Int32.Parse(Console.ReadLine());

                Console.Write("Anna numero: ");
                int num2 = Int32.Parse(Console.ReadLine());

                Console.Write("Anna numero: ");
                int num3 = Int32.Parse(Console.ReadLine());


                Double Sum = num + num2 + num3;

                Double average = ((double)Sum) / 3;

                Console.WriteLine("Summa on: " + Sum);
                Console.WriteLine("Keskiarvo on: " + average);


                Console.ReadLine();
            }

            
      
            
               
        }
           




        
    }
}
