using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd Rhcp = new Cd();
            Rhcp.Name = "RHCP";
            Rhcp.Artisti = "Red hot Chili Peppers";
            Rhcp.Biisit.Add(new Biisi("Californication", "2:55"));
            Rhcp.Biisit.Add(new Biisi("Can`t Stop", "2:55"));
            Rhcp.Biisit.Add(new Biisi("Under The Brigde", "2:55"));
            Rhcp.Biisit.Add(new Biisi("Otherside", "2:55"));
            

            Console.WriteLine(Rhcp.ToString());
        }
    }
    
}
