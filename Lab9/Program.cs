using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 1)
            {
                int thisThrow = DiceRandom.Next(1, 6);
                DiceThrow[0 + i] += thisThrow;
                Console.ReadLine();
                Console.Write(Player[0 + i] + " rolled a " + thisThrow);
                if (thisThrow != 6) i++;
            }

            Console.ReadLine();
            PlayerTotal[0] += DiceThrow[0];
            PlayerTotal[1] += DiceThrow[1];


            Console.ReadLine();
            Console.Write(Player[0] + " currently has " + PlayerTotal[0]);
            Console.ReadLine();
        }      
    }
}
