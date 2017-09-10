using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab12
    {

        public static void Tehtava12()
        {
            Console.WriteLine("Enter a Number");
            //int numb = int.Parse(Console.ReadLine());
            int reverse = 0;
            // declare numbers as an int array of any size
            int[] numb = new int[5]  // numbers is a 10-element array

            
            while (numb > 0)
            {
                int rem = numb % 10;
                reverse = (reverse * 10) + rem;
                numb = numb / 10;

            }

            
            Console.WriteLine("Reverse number={0}", reverse);
            Console.ReadLine();
        }
    }
}


