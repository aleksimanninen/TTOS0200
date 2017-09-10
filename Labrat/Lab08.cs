using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Aleksi Manninen 10.9.2017
// Ohjelma joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
namespace Labrat
{
    class Lab08
    {
        public static void Tehtava8()
        {


            int a;
            int b;
            int c;

            Console.Write("Anna luku > ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
             c = int.Parse(Console.ReadLine());

           
            {
                if (a > b && a> c)
                {
                    Console.WriteLine("Suurin luku on: " + a);
                }

                else if (b > a  &&  b > c)
                {
                    Console.WriteLine("Suurin luku on: " + b);
                }
             
                else 
                    Console.WriteLine("Suurin luku on:  " + c);

                
            }

            Console.ReadLine();
            











        }
    }
}
