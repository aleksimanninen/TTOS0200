﻿using System;
/// <summary>
/// A simple example of Blackjack card game
/// Aleksi Manninen testi
/// </summary>

namespace Hello
{
    public class BlackJack
    {
        public static void Blackjacks()
        {
            int myNumber = 17;
            int theirNumber;
            System.Console.WriteLine("*** BlackJack! ***");
            System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting

            do
            {
                theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                //comparing that given umber is valid



                if (theirNumber < 1 || theirNumber > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again between 1-21.");
                }
                else
                {
                    //comparing
                    if (theirNumber >= myNumber && theirNumber <= 21)
                    {
                        System.Console.WriteLine("You win.");
                    }
                    else
                    {
                        System.Console.WriteLine("You lose.");
                    }
                }
            } while (theirNumber < 1 || theirNumber > 21);

        }
    }
}