using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Product> kärryt = new List<Product>();
            kärryt.Add(new Product("Mjölk", 1.14));
            kärryt.Add(new Product("Pihvi", 10));
            kärryt.Add(new Product("Ananas", 2));

            Console.WriteLine("All products in collection:");
            foreach (Product tavara in kärryt)
            {
                Console.WriteLine(tavara.ToString());
            }
        }
    }
}
