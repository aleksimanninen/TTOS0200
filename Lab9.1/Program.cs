using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] pisteet = new int[6];

            int noppaluku = rnd.Next(1, 7);

            double summa = 0;

            Console.WriteLine("Dice, one test throw value is " + noppaluku);
            Console.WriteLine("How many times you want to throw a dice : ");

            int heitot = int.Parse(Console.ReadLine());
            for (int i = 0; i < heitot; i++)
            {
                noppaluku = rnd.Next(1, 7);
                pisteet[noppaluku - 1]++;
                summa += noppaluku;
            }
            
            Console.WriteLine("Dice is now thrown {0} times, average is {1}", heitot, summa / heitot);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("- {0} count is {1}", i + 1, pisteet[i]);

            }

        }
    }
}