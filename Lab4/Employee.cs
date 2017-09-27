using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Employee
    {

         
        public string Name { get; set; }

        public string Profession { get; set; }
        public int Salary { get; set; }


        public Employee()
        {

        }

        // constructor takes person firstname and lastname as a parameter
        public Employee(string name)
        {
            name = Name;

        }

        public override string ToString()
        {
            return "Nimi: " + Name + " Ammatti: " + Profession + " Palkka:  " + Salary ;
        }
    }
}


    

