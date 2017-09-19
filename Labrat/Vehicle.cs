using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

       
        

        public string tiedot()
        {
            return "Merkki: " + Name + "\n" + "Nopeus: " + Speed + " km/h " + "\n" + "Renkaan koko tuumina: " + Tyres + ".";
        }
        
        
            public static void Testaavehicle()
            {
                Vehicle Myvehicle = new Vehicle();

                Console.WriteLine("Anna auton merkki:");
                Myvehicle.Name = Console.ReadLine();
                Console.WriteLine("Anna Huippunopeus: (km/h)");
                Myvehicle.Speed = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna renkaiden koko:");
                Myvehicle.Tyres = int.Parse(Console.ReadLine());



                Console.WriteLine("Haluatko tulostaa auton tiedot? 1.Auton tiedot 2.Lopeta");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine(Myvehicle.tiedot());
                }
                else
                {
                    return;
                }
            }
     }
 }

    

