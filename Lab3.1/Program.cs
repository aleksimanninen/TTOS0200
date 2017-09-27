using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            LiikutaHissia();
        }
        static void LiikutaHissia()
        {
            Hissi hissi = new Hissi();

            while (true)
            {
                Console.WriteLine("Anna kerros(1-5)>");
                hissi.Kerros = int.Parse(Console.ReadLine());
                Console.WriteLine("Hissi on nyt kerroksessa> " + hissi.kerros);
            }
        }
    }
}