using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labrat
{
    class Lab01
    {

        public static void Tehtava1()
        {
            // Aleksi Manninen 6.9.2017
            //Tee ohjelma, joka tulostaa käyttäjän antamaa lukua(1, 2 tai 3) vastaavan luvun sanana(yksi, kaksi tai kolme)
            //Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".

            int luku;
            Console.Write("Anna luku (1-3) > ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }

            else if (luku == 2)
                Console.WriteLine("Annoit luvun kaksi");

            else if (luku == 3)
                Console.WriteLine("Annoit luvun kolme");

            else if (luku > 3)
                Console.WriteLine("joku muu luku");


            Console.ReadLine();

        }


        public static void Tehtava2()
        {
            //Aleksi Manninen 6.9.2017
            /*Ohjelma jossa annetaan oppilaalle koulunumero
            seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)*/


            int luku;
            Console.Write("Anna pistemäärä > ");
            luku = int.Parse(Console.ReadLine());

            if (luku >= 0 && luku <= 1)
            {

                Console.WriteLine("Koulunumero on 0");
            }

            else if (luku >= 2 && luku <= 3)
                Console.WriteLine("Koulunumero on 1");

            else if (luku >= 4 && luku <= 5)
                Console.WriteLine("Koulunumero on 2");

            else if (luku >= 6 && luku <= 7)
                Console.WriteLine("Koulunumero on 3");

            else if (luku >= 8 && luku <= 9)
                Console.WriteLine("Koulunumero on 4");

            else if (luku >= 10 && luku <= 12)
                Console.WriteLine("Koulunumero on 5");

            Console.ReadLine();






        }


        public static void Tehtava3()
        {
            //Aleksi Manninen 6.9.2017
            //Ohjelma joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.

            {


                Console.Write("Anna numero: ");
                int num = Int32.Parse(Console.ReadLine());

                Console.Write("Anna numero: ");
                int num2 = Int32.Parse(Console.ReadLine());

                Console.Write("Anna numero: ");
                int num3 = Int32.Parse(Console.ReadLine());


                Double Sum = num + num2 + num3;

                Double average = ((double)Sum) / 3;

                Console.WriteLine("Summa on: " + Sum);
                Console.WriteLine("Keskiarvo on: " + average);


                Console.ReadLine();
            }





        }


        public static void Tehtava4()
        {
            //Aleksi Manninen 6.9.2017
            //Ohjelma jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen",
             // jos se on 18-65 vuotta,tulosta "aikuinen", muussa tapauksessa tulosta "seniori".


            Console.Write("Anna Ikäsi: ");
            int ikä = Int32.Parse(Console.ReadLine());


            if (ikä >= 0 && ikä <= 18)
            {

                Console.WriteLine("Alaikäinen");
            }


            else if (ikä >= 18 && ikä <= 65)
            {

                Console.WriteLine("aikuinen");
            }

            else if (ikä < 65)
            {

                Console.WriteLine("Seniori");
            }




        }


        public static void Tehtava5()
        {
            //Aleksi Manninen 10.9.2017
            //Ohjelma joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina.
            // Aikamääre sekuntteina kysytään käyttäjältä.


            Console.Write("Anna sekunnit: ");
            int totalsek = Int32.Parse(Console.ReadLine());
            int sek = (totalsek % 60);
            int min = (totalsek % 3600) / 60;
            int hour = totalsek / 3600;



            Console.WriteLine(" Antamasi sekunttiaika voidaan ilmaista muodossa: " + hour + " tuntia  " + min + " minuuttia  " + sek + " sekunttia  ");


        }


        public static void Tehtava6()
        
        {
            //Aleksi Manninen 10.9.2017
            //Ohjelma joka tulostaa ajetulla matkalla (kysytään käyttäjältä) 
            //kuluvan bensan määrän sekä bensaan menevän rahan määrän.

            double kulutus = 7.02;
            double bensa = 1.595;
            double kustannus;
            double hinta;
            double matka;

            Console.Write("Anna Matka: ");
            matka = Int32.Parse(Console.ReadLine());

            kustannus = (matka / 100) * kulutus;
            hinta = kustannus * bensa;



            Console.WriteLine(" Bensaa kuluu " + kustannus + "kustannus " + hinta + " euroa");



        }

        public static void Tehtava7()
        {
            //Aleksi Manninen 10.9.2017
            //Ohjelma joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä
            Console.WriteLine("Anna vuosi:");
            int vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 400 == 0 || (vuosi % 4 == 0 && vuosi % 100 != 0))  // 400 jaollinen tai täydet neljällä jaolliset täydet vuosisadat.
            {
                Console.WriteLine("Vuosi on karkausvuosi");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi");
            }
            Console.ReadLine();



        }


        public static void Tehtava8()
        {
            // Aleksi Manninen 10.9.2017
            // Ohjelma joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.

            int a;
            int b;
            int c;

            Console.Write("Anna luku > ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            c = int.Parse(Console.ReadLine());


            {
                if (a > b && a > c)
                {
                    Console.WriteLine("Suurin luku on: " + a);
                }

                else if (b > a && b > c)
                {
                    Console.WriteLine("Suurin luku on: " + b);
                }

                else
                    Console.WriteLine("Suurin luku on:  " + c);


            }

            Console.ReadLine();


        }


        public static void Tehtava9()

        {
            //Aleksi Mannninen 10.9.2017
            //Ohjelma joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0.
            //Ohjelman tulee tulostaa syötettyjen lukujen summa.


            {
                int luku;
                int sum = 0;
                while (true)  //while (luku !=0);  Huomio!!!
                {
                    Console.Write("Anna Luku: ");
                    luku = int.Parse(System.Console.ReadLine());

                    if (luku == 0)  // jos 0 katkeaa
                    {
                        break;
                    }
                    else if (luku != 0) // jos eri kuin 0 laskee summaa taustalla
                    {
                        sum = sum + luku;
                        continue;
                    }

                }
                Console.WriteLine("Lukujen summa on: " + sum);
            }

        }


        public static void Tehtava10()
        
        {
            // Aleksi Manninen 10.9.2017
            //Ohjelma joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100].


            int[] luvut = new int[] { 1, 2, 33, 44, 55, 68, 77, 98, 100 };

            for (int i = 0; i < luvut.Length; i++)
            {

                if (luvut[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
                else if (luvut[i] % 2 != 0)
                {
                    Console.WriteLine("*");
                }


            }



        }


        public static void Tehtava11()
         {
            //Aleksi Manninen 10.9.2017
            //Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion * ** ***

            int i;

            Console.Write("Anna luku: ");
            i = int.Parse(Console.ReadLine());

            for (int b = 0; b <= i; b++)
            {

                for (int merkki = 0; merkki < b; merkki++)
                {
                    Console.Write("*");
                }


                Console.Write("\n\r");


            }


        }


        public static void Tehtava12()
        {
            //Aleksi Manninen 11.9.2017
            //Ohjelma joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon.
            // Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.


            int[] num = new int[5]; // alustetaan taulukko 5 luvulle


            for (int i = 0; i < 5; i++)    // kysyy 5 lukua
            {

                Console.WriteLine("Anna luku");
                num[i] = int.Parse(System.Console.ReadLine());
            }
            for (int b = 4; b > -1; b--)                //b-- kääntää jonon
            {
                Console.Write(" " + num[b] + " ");
            }

            Console.ReadLine();
        }


        public static void Tehtava13()
        {
            //Aleksi Manninen 11.9.2017
            //Ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten,
            // että summasta on vähennetty pois pienin ja suurin tyylipiste.


            int[] num = new int[5]; // alustetaan taulukko 5 luvulle
            int sum;


            for (int i = 0; i < num.Length; i++)

            {
                Console.WriteLine("Anna pisteet");
                num[i] = int.Parse(System.Console.ReadLine());

            }


            Array.Sort(num);
            sum = num[1] + num[2] + num[3];  // Jättää pois isoimman ja pienemmän arvon
            System.Console.WriteLine("Pisteet ovat: " + sum);



            Console.ReadLine();
        }


        public static void Tehtava16()
         {
            //Aleksi Manninen 12.9.2017
            //Ohjelma joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa.
            //Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku.
            {
                Random r = new Random();
                int num = (r.Next(0, 101));
                int i = 1;
                int luku;



                while (true)
                {
                    Console.Write("Arvaa luku: ");
                    luku = int.Parse(System.Console.ReadLine());

                    if (luku == num)  // Luku on oikein
                    {
                        Console.WriteLine("Hienoa, arvasit luvun " + i + " yrityksellä!");
                        break;
                    }
                    else if (luku != num) // Luku ei ole oikein
                    {
                        if (luku > num)
                        {
                            Console.WriteLine("Luku on pienempi");
                            i++;
                        }

                        else
                        {
                            Console.WriteLine("Luku on suurempi");
                            i++;
                        }

                    }


                }

            }



        }


        public static void Tehtava18()
        {
            //Aleksi Manninen 12.9.2017
            //Ohjelma joka kysyy käyttäjältä merkkijonon (lause).
            // Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.

            string word;
            Console.WriteLine("Anna sana");
            word = Console.ReadLine();  //ottaa annetun sanan "talteen"


            char[] array = word.ToCharArray(); // sana taulukkoon

            for (int i = 0; i < array.Length; i++)
            {
                char letter = array[i];  //sijoittaa kirjaimet paikalleen
            }

            Array.Reverse(array);   //käännetään ympäri

            string reversed = new string(array);

            if (word == reversed)
            {
                Console.WriteLine("Palindromi");

            }
            else
            {
                Console.WriteLine("Ei Palindromi");
            }
        }


        public static void Tehtava20()
        {
            //Aleksi Manninen 12.9.2017
            //Tehätävä 20: "Laskin"

            
                int ekanum, tokanum;

                string oper;
                int ans;


                Console.WriteLine("****************************");
                Console.WriteLine("*       Perus Laskin       *");
                Console.WriteLine("* Paina Enter- jatkaaksesi *");
                Console.WriteLine("****************************");


                Console.ReadLine();

                Console.Write("Syötä ensimmäinen luku: ");
                ekanum = Convert.ToInt32(Console.ReadLine());


                Console.Write("Syötä toinen luku: ");
                tokanum = Convert.ToInt32(Console.ReadLine());
                Console.Write("Valitse toiminpide ( x , / , +, -) ");
                oper = Console.ReadLine();


                if (oper == "x") //kertolasku
                {
                    ans = ekanum * tokanum;
                    Console.WriteLine(" = " + ans);
                    Console.ReadLine();
                }
                else if (oper == "/")  //jakolasku
                {
                    ans = ekanum / tokanum;
                    Console.WriteLine(" = " + ans);
                    Console.ReadLine();
                }

                else if (oper == "+")  // + ja - laskut
                {
                    ans = ekanum + tokanum;
                    Console.WriteLine(" = " + ans);
                    Console.ReadLine();
                }
                else if (oper == "-")
                {
                    ans = ekanum - tokanum;
                    Console.WriteLine(" = " + ans);
                    Console.ReadLine();
                }

            
        }
    }
}
