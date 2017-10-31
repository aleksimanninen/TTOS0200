﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0;
                string filupath = (@"D:\Temp\nimet.txt");
                if (!File.Exists(filupath))
                {
                    Console.WriteLine("Tiedostoa ei ole.");
                }
                else
                {
                    foreach (var Line in File.ReadAllLines(filupath))
                    {
                        a++;
                    }
                    var nameCount = new Dictionary<string, int>();
                    foreach (String s in File.ReadAllLines(filupath))
                    {
                        if (nameCount.ContainsKey(s))
                        {
                            nameCount[s] = nameCount[s] + 1;
                        }
                        else
                        {
                            nameCount.Add(s, 1);
                        }
                    }

                    Console.WriteLine("Tiedosta löytyi " + a + " riviä, ja " + nameCount.Count + " nimeä");
                    foreach (var pair in nameCount)
                    {
                        Console.WriteLine("Nimi {0} esiintyy {1} kertaa", pair.Key, pair.Value);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
