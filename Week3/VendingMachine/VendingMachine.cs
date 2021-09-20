/// Week 3 Homework 2
/// File Name: VendingMachine.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: This program determines change when purchasing an item costing between 25 cents and a dollar.
/// 
/// Overall Plan
/// 1. Create variables for item price and each coin
/// 2. Take user input to get the value of the item being purchased
/// 3. Use integer division to get change.
///
/// Classes Needed and Purpose: 
/// Main Class: Handles everything in main

using System;

namespace VendingMachine
{
    class VendingMachine
    {
        static void Main(string[] args) {
            const int PAYMENT = 100; // Representing the dollar being used to pay for the item.
            int itemCost = 0; // Cost of the item being purchased (in cents)
            int change = 0;
            
            // Variables below indicate the number of each coin being given back in change
            int quarters = 0;
            int dimes    = 0;
            int nickels  = 0;
            int pennies  = 0;

            // Gathering input from the user and updating the itemCost value
            Console.Write("Enter price of item (from 25 cents to a dollar, in 5-cent increments): ");
            itemCost = Int32.Parse(Console.ReadLine());

            // Calculating the change owed
            change = PAYMENT - itemCost;

            // Calculating change in coins
            // Quarters
            quarters = change / 25; // The result of this expression is the number of quarters owed
            change -= quarters * 25; // Updating how much we owe after giving the quarters

            // Dimes
            dimes = change / 10; // Number of dimes owed
            change -= dimes * 10; // Updating change

            // Nickels
            nickels = change / 5; // Number of nickels owed
            change -= nickels * 5; // Updating change

            // Pennies (Not necessary for this project but it felt incomplete without it)
            pennies = change; // Number of pennies owed
            change -= pennies; // Updating change (Could also just be set to 0)

            // Outputting to the user
            Console.WriteLine("Change Owed:\nQuarters: {0}\nDimes: {1}\nNickels: {2}\nPennies: {3}", quarters, dimes, nickels, pennies);
        }
    }
}
