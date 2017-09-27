using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public override string ToString()
        {
            return base.ToString() + " Auto: " + Car + " Bonus: " + Bonus;
        }



    }


}
