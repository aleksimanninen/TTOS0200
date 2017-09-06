using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Aleksi Manninen 6.9.2017
 //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua(1, 2 tai 3) vastaavan luvun sanana(yksi, kaksi tai kolme)
 //Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
namespace Labrat
{
    class Lab01
    {

       public static void Tehtava1()
        {
           
            
            int luku;
            Console.Write("Anna luku (1-3) > ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
             }

           else if ( luku == 2) 
                Console.WriteLine("Annoit luvun kaksi");

            else if (luku == 3)
                Console.WriteLine("Annoit luvun kolme");
                    
            else if (luku > 3)
                Console.WriteLine("joku muu luku");


                 Console.ReadLine();
       
            
             

           
           
        }



    }
}
