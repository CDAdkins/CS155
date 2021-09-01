/// Week 2 Homework 1
/// File Name: PigLatin.cs
/// @author: Chris Adkins
/// Date: 8/31/21
///
/// Problem Statement: 
/// This program takes a first and last name and converts it into Pig Latin.
/// 
/// Overall Plan
/// 1. Get input from user for names
/// 2. Create substring starting with the character of each name at index 1
/// 3. Capitalize the letter at index one then add the index 0 letter to the end of the name, lowercase and add "ay"

using System;

namespace PigLatin
{
    class PigLatin
    {
        static void Main(string[] args) {
            // Declaring our variables
            string first;      // First name before conversion
            string last;      // Last name before conversion
            string firstPig; // First name post conversion
            string lastPig; // Last name post conversion

            // Initializing Variables w/ user input
            Console.Write("Enter your first name: ");
            first = Console.ReadLine();
            Console.Write("Enter your last name: ");
            last = Console.ReadLine();

              // Converting the first and last name into Pig Latin
             // First we take the second letter of each name and use ToUpper to capitalize it, then we take the remainder of the name and concatenate it to the first letter.
            // We then take the first letter of each name, make it lowercase, then add it to the end of the string. We then add "ay" to the end of the string.
            firstPig = first[1].ToString().ToUpper() + first.Substring(2) + first[0].ToString().ToLower() + "ay";
            lastPig = last[1].ToString().ToUpper() + last.Substring(2) + last[0].ToString().ToLower() + "ay";

            Console.Write("{0} {1} -> {2} {3}", first, last, firstPig, lastPig);
        }
    }
}
