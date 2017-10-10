using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Jääkaappi
    {
        public string Name { get; set; }
        public List<Elintarvike> sisältö;
        
        public Jääkaappi()
        {
            sisältö = new List<Elintarvike>();

        }
        
        public override string ToString()
        {
            string retval = Name + " sisältö:\n";
            foreach (Elintarvike item in sisältö)
            {
                retval += item.ToString() + "\n";
            }
            return retval;

        }
    }
}
