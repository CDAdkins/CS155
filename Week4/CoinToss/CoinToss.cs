/// Week 4 Homework 2
/// File Name: CoinToss.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: This program asks the user for the results of 8 coin tosses and reports the percentage of heads and tails to the user.
/// 
/// Overall Plan
/// 1. Create variables for tosses, heads and tails
/// 2. Create a for loop to get input from the user a number of times
/// 3. Report results to the user.
///
/// Classes Needed and Purpose: 
/// Main Class: Contains everything in main

using System;

namespace CoinToss
{
    class CoinToss
    {
        static void Main(string[] args) {

            double numTosses = 0; // The total number of coin tosses.
            double heads = 0;    // Number of times the coin lands on heads.
            double tails = 0;   // Number of times the coin lands on tails.

            Console.WriteLine("For each coin toss enter either ‘h’ for heads or ‘t’ for tails");
            for (int i = 0; i < 8; i++) { // Loop eight times
                String decision; // Represents either h or t once the user chooses.
                numTosses++;
                Console.Write("Toss " + (i + 1) + ": "); // Getting input from user.
                decision = Console.ReadLine();
                
                if (decision == "h") { // If the user types "h", increment heads
                    heads++;
                } else {
                    tails++; // otherwise increment tails
                }
            }

            // Outputting to user.
            Console.WriteLine("\nNumber of Heads: {0}\nNumber of Tails: {1}\nPercent of Heads: " + Math.Round(heads / numTosses * 100, 4) + 
                                                   "%\nPercent of Tails: " + Math.Round(tails / numTosses * 100, 4) + "%", heads, tails);
        }
    }
}
