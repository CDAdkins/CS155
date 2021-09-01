/// Chapter 2, Lab 2
/// File Name: Coupons.cs
/// @author: Chris Adkins
/// Date: 8/31/21
///
/// Problem Statement: This program takes a number of coupons and tells the user how many candy bars and gumballs they can get
///                    if candy bars are worth 10 coupons and gumballs are worth 3.
/// 
/// Overall Plan
/// 1. Get the number of coupons from the user
/// 2. Divide the number of coupons by 10 to get the candy bars, modulo the number of coupons by 10 to get the remaining coupons.
/// 3. Divide remaining coupons by 3 to get gumballs then modulo the remaining coupons by 3 to get the coupons left at the end.

using System;

namespace Lab2
{
    class Coupons
    {
        static void Main(string[] args) {
            // Declaring Variables
            int numCoupons; // initial number of coupons earned
            int remainingCoupons; // Coupons remaining after redemption.
            int numCandyBars; // Number of candy bars earned
            int numGumballs; // Number of Gumballs earned

            // Getting input from user
            Console.Write("How many coupons did you win? ");
            numCoupons = Int32.Parse(Console.ReadLine()); // Passing the user's input into the numCoupons variable.
            remainingCoupons = numCoupons;

            numCandyBars = numCoupons / 10; // Getting the number of candy bars
            remainingCoupons %= 10; // Getting the coupons left over
            numGumballs = remainingCoupons / 3; // Getting the number of gumballs
            remainingCoupons %= 3; // Finding how many tickets remain.
            // Outputting results to the user
            Console.WriteLine("For {0} Coupons you can get:\nCandy Bars: {1}\nGumballs: {2}\n" +
            "Coupons Remaining: {3}", numCoupons, numCandyBars, numGumballs, remainingCoupons);
        }
    }
}
