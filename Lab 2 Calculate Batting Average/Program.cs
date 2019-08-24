/*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            double dbHits, nAtBats;
            double dblBattingAverage;
            //prompt for name and receive
            Console.WriteLine("~This program calculates a baseball player's batting average~");
            Console.WriteLine("<------------------------------------------------------------>");
            Console.WriteLine("");
            Console.WriteLine("Enter the player name: ");
            strPlayerName = Console.ReadLine();

            //prompt for hits, walks and at bats
            Console.WriteLine("Enter the player's # of hits:  ");
            dbHits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the player's # of at bats:  ");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = dbHits / nAtBats;

            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();

        }
    }
}