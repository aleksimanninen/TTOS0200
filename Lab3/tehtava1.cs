using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
      public static class Luku
    {
       //static bool number { get; set; }
       //static bool date { get; set; }

     public static bool Onkoluku(string syote)
        {
            if (syote == "testi")
            {
                Console.WriteLine("TOimiiiii");
                return true;
            }
            else
            {
                return false;
            }
        }
     public static bool OnkoPvm(string syote)
        {
            return false;
        }

    }
}
