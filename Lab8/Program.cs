using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÄYTTÄÄKÄÄ AINA TRY-CATCHIÄ
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //kirjoitetaan käyttäjän antamat rivit tiedostoon
                //luodaan StreamWriter tyypiinen olio johon kirjoitetaan

                StreamWriter sw = new StreamWriter(filu);
                do
                {
                    Console.Write("Anna nimi (Enter lopettaa):\n");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close();

                // avataan tiedosto uudestaan ja luetaan sen sisältö ja näytetään
                // tarkistetaan löytyykö tiedosto
                if (File.Exists(filu))
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy!"); // yleensä yksi exception riittää!
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
    

            
        }
    }
}
