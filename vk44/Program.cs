using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vk44

{
    public struct Ohjastaja
    {
        public string Nimi;
        public int Startit;
        public int Voitot;
        public float Voittopros;
    }
    class Program
    {
        static void LueOhjastajatVer2()
        {
            try
            {
                //luetaan csv-tiedostosta tiedot ja tallentaan ne structeihin?!
                string erotin = ";";
                string[] rivit = System.IO.File.ReadAllLines(@"d:\K2344\tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteesä {0},", lkm - 1);
                for (int i = 1; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if(int.TryParse(sanat[2], out int apu))
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1];
                        kuski.Startit = int.Parse(sanat[2]);
                        kuski.Voitot = int.Parse(sanat[3]);
                        kuski.Voittopros = (100F * kuski.Voitot / kuski.Startit);
                    }
                    else
                    {
                        kuski.Nimi = sanat[0] + " " + sanat[1] + " " + sanat[2];
                        kuski.Startit = int.Parse(sanat[3]);
                        kuski.Voitot = int.Parse(sanat[4]);
                        kuski.Voittopros = (100F * kuski.Voitot / kuski.Startit);

                    }
                    

                    //tulos
                    Console.WriteLine("{0}: {1} startit {2} voitot {3} voittoprosentti {4}", i, kuski.Nimi, kuski.Startit, kuski.Voitot, kuski.Voittopros);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        static void LueOhjastajatVer1()
        {
            try
            {
                //luetaan tiedosto läpi rivi kerrallaa
                int counter = 0;
                string line;
               System.IO.StreamReader stream = new System.IO.StreamReader(@"d:\K2344\tilasto2017.txt");
                while ((line = stream.ReadLine()) != null)
                {
                    Console.WriteLine(counter + ": " + line);
                    counter++;
                }

            }
            catch (Exception)

            {
                throw;
            }
        }
   

        static void Main(string[] args)
        {
            try
            {
                LueOhjastajatVer2();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
