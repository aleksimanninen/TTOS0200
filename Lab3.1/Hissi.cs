using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    //Aleksi Manninen 26.9.2017
    class Hissi
    {
        private readonly int Maxkerros = 5;
        private readonly int Minkerros = 1;

        public int kerros;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                if (value <= Maxkerros && value >= Minkerros) kerros = value;
                else
                {
                    Console.WriteLine("Kerros ei voi olla yli viisi tai alle yksi.");
                    kerros = Kerros;
                }
            }
        }
    }
}