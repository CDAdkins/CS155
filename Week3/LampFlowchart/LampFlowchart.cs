/// Week 3 Lab 2
/// File Name: LampFlowchart.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: This program simulates a flowchart by using some if-statements
/// 
/// Overall Plan
/// 1. Create a variable to track user decisions
/// 2. Ask the user a question
/// 3. If the user types 'y', then write something, otherise write something else.
///
/// Classes Needed and Purpose: 
/// Main Class: Main handles everything

using System;
namespace LampFlowchart
{
    class LampFlowchart
    {
        static void Main(string[] args) {
            String decision; // Variable to indicate whether or not the user typed "y"

            Console.WriteLine("Your lamp is not working!");
            Console.WriteLine("Is your lamp plugged in? (y/n)");

            decision = Console.ReadLine();

            if (decision == "y") {
                Console.WriteLine("Is the bulb burned out?");
            } else {
                Console.WriteLine("Plug in the lamp!");
                return;
            }

            decision = Console.ReadLine();

            if (decision == "y") {
                Console.WriteLine("Replace the bulb!");
            } else {
                Console.WriteLine("Repair the lamp!");
            }
        }
    }
}
