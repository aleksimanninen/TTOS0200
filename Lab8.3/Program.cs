using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string filupath1 = (@"D:\Temp\integers.txt");
                string filupath2 = (@"D:\Temp\doubles.txt");
                string syöte;
                int integers;
                double doubles;

                while (true)
                {
                    Console.WriteLine("Give a number (enter or not a number ends): ");
                    syöte = Console.ReadLine();

                    if (int.TryParse(syöte, out integers))
                    {
                        Console.WriteLine("Number is integer");
                        if (!File.Exists(filupath1))
                        {
                            using (StreamWriter sw = File.CreateText(filupath1))
                            {
                                sw.WriteLine("Integer-File");
                            }
                        }
                        using (StreamWriter sw = File.AppendText(filupath1))
                        {
                            sw.WriteLine(syöte);
                        }
                    }
                    else if (double.TryParse(syöte, out doubles))
                    {
                        Console.WriteLine("Number is double.");
                        if (!File.Exists(filupath2))
                        {
                            using (StreamWriter sw = File.CreateText(filupath2))
                            {
                                sw.WriteLine("Double-File");
                            }
                        }
                        using (StreamWriter sw = File.AppendText(filupath2))
                        {
                            sw.WriteLine(syöte);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That wasn`t a number!");
                        break;
                    }
                }
                string text1 = System.IO.File.ReadAllText(filupath1);
                System.Console.WriteLine("Content of integers.txt: " + text1);

                string text2 = System.IO.File.ReadAllText(filupath2);
                System.Console.WriteLine("Content of doubles.txt: " + text2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    
    }
}
