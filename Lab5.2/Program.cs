using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Jääkaappi Elextrolux = new Jääkaappi();
            Elextrolux.Name = "Jääkaappi";

            Elextrolux.sisältö.Add(new Elintarvike("Maito", "Ovi"));
            Elextrolux.sisältö.Add(new Elintarvike("Limppari", "Ovi"));
            Elextrolux.sisältö.Add(new Elintarvike("J-Liha", "Ylähylly"));
            Elextrolux.sisältö.Add(new Elintarvike("Juusto", "Ylähylly"));
            Elextrolux.sisältö.Add(new Elintarvike("Tomaatti", "Alahylly"));
            Elextrolux.sisältö.Add(new Elintarvike("Kurkku", "Alahylly"));

            Console.WriteLine(Elextrolux.ToString());

        }
    }
}
