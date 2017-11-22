using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertaustehtävä
{
    class Program
    {
         public static void Main(string[] args)
        {
            Opintojakso Opint = new Opintojakso("Olio-Ohjelmointi");

            Opint.OP.Add(new Opiskelija("Aleksi Manninen", 23,"a1234" , "TTV16S1"));
            Opint.OP.Add(new Opiskelija("Paavo Manninen", 22,"a2345", "TTV16S1"));
            Opint.OP.Add(new Opiskelija("Ilmari Åsenbrygg", 21,"a4567", "TTV16S1"));
            Opint.OPE.Add(new Opettaja("Matti Meikäläinen", 59, 40222290890));
            

            Opintojakso Opint1 = new Opintojakso("Kertaus");

            Opint1.OP.Add(new Opiskelija("Aleksi Manninen", 23, "a1234", "TTV16S1"));
            Opint1.OP.Add(new Opiskelija("Paavo Manninen", 22, "a2345", "TTV16S1"));
            Opint1.OP.Add(new Opiskelija("Ilmari Åsenbrygg", 21, "a4567", "TTV16S1"));
            Opint1.OPE.Add(new Opettaja("Matti Meikäläinen", 59, 4040089081));
           

            Opintojakso Opint2 = new Opintojakso("Tietoverkot");

            Opint2.OP.Add(new Opiskelija("Aleksi Manninen", 23, "a1234", "TTV16S1"));
            Opint2.OP.Add(new Opiskelija("Paavo Manninen", 22, "a2345", "TTV16S1"));
            Opint2.OP.Add(new Opiskelija("Ilmari Åsenbrygg", 21, "a4567", "TTV16S1"));
            Opint2.OPE.Add(new Opettaja("Matti Meikäläinen", 59, 4040089089));
            

            Tutkinto Tutk1 = new Tutkinto("AMK");
            Tutk1.TK.Add(Opint);
            Tutk1.TK.Add(Opint1);
            Tutk1.TK.Add(Opint2);

            Amk Amk1 = new Amk("Ammattikorkeakoulu/Insinööri");
            Amk1.Tutkintotyyppi.Add(Tutk1);

            Opintojakso Opint3 = new Opintojakso("Ohjelmointi");

            Opint3.OP.Add(new Opiskelija("Aleksi Manninen", 23, "a1234", "TTV16S1"));
            Opint3.OP.Add(new Opiskelija("Paavo Manninen", 22, "a2345", "TTV16S1"));
            Opint3.OP.Add(new Opiskelija("Ilmari Åsenbrygg", 21, "a4567", "TTV16S1"));
            Opint3.OPE.Add(new Opettaja("Matti Meikäläinen", 59, 4040089093));
            

            Opintojakso Opint4 = new Opintojakso("Fysiikka 1");

            Opint4.OP.Add(new Opiskelija("Tiia Tiainen", 22, "K1234",  "TTV17S1"));
            Opint4.OP.Add(new Opiskelija("Jorma Jokinen", 22,"K2345", "TTV17S1"));
            Opint4.OP.Add(new Opiskelija("Ville Virtanen", 29,"K3456", "TTV17S1"));
            Opint4.OPE.Add(new Opettaja("Jussi Jormanen", 34, 4040080894));
            

            Opintojakso Opint5 = new Opintojakso("Matikka 2");

            Opint5.OP.Add(new Opiskelija("Matti Mustonen", 18,"F2341", "TTV17S1"));
            Opint5.OP.Add(new Opiskelija("Iiro Kolehmainen", 18,"F5412", "TTV17S1"));
            Opint5.OP.Add(new Opiskelija("Markus Asikainen", 18,"F5712", "TTV17S1"));
            Opint5.OPE.Add(new Opettaja("Toni Pekkarinen", 35, 4040089895));
            

            Tutkinto Tutk2 = new Tutkinto("YAMK/Maisteri");
            Tutk2.TK.Add(Opint3);
            Tutk2.TK.Add(Opint4);
            Tutk2.TK.Add(Opint5);

            Amk Ymk1 = new Amk("YMK");
            Ymk1.Tutkintotyyppi.Add(Tutk2);

            Console.WriteLine(Amk1.ToString());
            Console.WriteLine(Ymk1.ToString());

        }
    }
}
