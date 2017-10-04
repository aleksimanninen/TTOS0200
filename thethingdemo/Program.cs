using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thethingdemo

{
    class Thing
    {
        // public string Name; //julkinen jäsenmuuttuja =! kuin ominaisuus

        //parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
        //public string Name { get; set; }
        //Tostring - metodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public override string ToString()
        {
            //return "Nimeni on: " + Name;
            //mutta mieleemmin jos on sisäinen muuttuja niin käytetään sitä
            return "nimeni on: " + name;
        }

    //CONSTRUCTORS
    public Thing()
        {
            name = "nobody here";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // se-Jostakin testaus
            //Thing t = new Thing();
            //Console.WriteLine(t.ToString());
            //t.Name = "jotakin";
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.ToString());



            //student-olion testaus
            Student s = new Student();
            s.FirstName = "Pekka";
            s.LastName = "Åsenbrygg";
            Student s2 = new Student("matti", "Jokunen");

            // luodaan kokoelma Student-olioita, käytetään List!!
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);
            students.Add(new Student("Paavo", "Åsenbrygg"));
            Console.WriteLine("Luokan Oppilaat");
            foreach (Student item in students)

            {
                Console.WriteLine(item.ToString());
            }

            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Aleksi", "Aurinkoinen"));
                Console.WriteLine(luokka.ToString());
        }
    }
}
