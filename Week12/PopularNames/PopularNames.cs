/// Week 12 Homework 1
/// File Name: PopularNames.cs
/// @author: Chris Adkins
/// Date: 12/6/2021
///
/// Problem Statement: This program parses two txt files, adds them to a dictionary and lists the popularity of the name by rank and total count.
/// 
/// Overall Plan
/// 1. Create a class to hold a rank and count of a name.
/// 2. Create two dictionary objects and add each name and its corresponding rank / count.
/// 3. Get input from the user and search each dictionary for the naem. If found, print the name and corresponding stats.
///
/// Classes Needed and Purpose: 
/// Main Class: PopularNames - holds most of the logic to add and search names
/// Other Class: NameCount - Contains two ints, one for the rank of a name, one for the number of times it has been used.

using System;
using System.IO;
using System.Collections.Generic;

namespace PopularNames {
    class PopularNames {
        static void Main(string[] args) {
            Dictionary<string, NameCount> boyNameDictionary = new Dictionary<string, NameCount>(); // Dictionary to be filled with boy names
            Dictionary<string, NameCount> girlNameDictionary = new Dictionary<string, NameCount>(); // Dictionary to be filled with girl names
            string boyNamesFile = "C:/Programming/CS155/Week12/PopularNames/boynames.txt"; // Path to boynames.txt
            string girlNamesFile = "C:/Programming/CS155/Week12/PopularNames/girlnames.txt"; // Path to girlnames.txt
            StreamReader nameReader = new StreamReader(boyNamesFile); // StreamReader to parse the txt files
            string currentLine; // Current line being read from the txt files
            string userInput; // Holds the user's input

            int lineNumber = 0; // int to keep track of popularity rank based on the current line number
            NameCount currentNameCount; // The rank and count of the name on the line currently being read
            string currentName; // The name on the line currently being read

            // While loop to populate the boyNameDictionary with the contents of boynames.txt
            while ((currentLine = nameReader.ReadLine()) != null) { // Loop until the end of boynames.txt
                lineNumber++; // Increase the line number once per line
                currentName = currentLine.Substring(0, currentLine.IndexOf(' ')); // Save every character until you reach a ' ' character
                currentNameCount = new NameCount(Int32.Parse(currentLine.Substring(currentLine.IndexOf(' '))), lineNumber); // Create a NameCount with the rank and line number

                boyNameDictionary.Add(currentName, currentNameCount); // Add the name and NameCount to the dictionary
            }

            // While loop to populate the boyNameDictionary with the contents of boynames.txt
            while ((currentLine = nameReader.ReadLine()) != null) { // Loop until the end of boynames.txt
                lineNumber++; // Increase the line number once per line
                currentName = currentLine.Substring(0, currentLine.IndexOf(' ')); // Save every character until you reach a ' ' character
                currentNameCount = new NameCount(Int32.Parse(currentLine.Substring(currentLine.IndexOf(' '))), lineNumber); // Create a NameCount with the rank and line number

                boyNameDictionary.Add(currentName, currentNameCount); // Add the name and NameCount to the dictionary
            }

            nameReader = new StreamReader(girlNamesFile); // StreamReader to parse the txt files
            lineNumber = 0;
            // While loop to populate the girlNameDictionary with the contents of girlnames.txt
            while ((currentLine = nameReader.ReadLine()) != null) { // Loop until the end of girlnames.txt
                lineNumber++; // Increase the line number once per line
                currentName = currentLine.Substring(0, currentLine.IndexOf(' ')); // Save every character until you reach a ' ' character
                currentNameCount = new NameCount(Int32.Parse(currentLine.Substring(currentLine.IndexOf(' '))), lineNumber); // Create a NameCount with the rank and line number

                girlNameDictionary.Add(currentName, currentNameCount); // Add the name and NameCount to the dictionary
            }

            // Get input from the user
            Console.Write("Please Enter a Name: ");
            userInput = Console.ReadLine();

            // Parse the dictionaries, see if the name exists, print the stats for the name both dictionaries
            if (boyNameDictionary.ContainsKey(userInput)) {
                Console.WriteLine(userInput + " is ranked " + boyNameDictionary[userInput].getRank() + " in popularity among boys with " + boyNameDictionary[userInput].getCount() + " namings.");
            } else {
                Console.WriteLine(userInput + " is not among the top 1000 boy names.");
            }

            if (girlNameDictionary.ContainsKey(userInput)) {
                Console.WriteLine(userInput + " is ranked " + girlNameDictionary[userInput].getRank() + " in popularity among girls with " + girlNameDictionary[userInput].getCount() + " namings.");
            } else {
                Console.WriteLine(userInput + " is not among the top 1000 girl names.");
            }

        }
    }

    class NameCount {
        // Class to keep track of a name's count and rank
        private int count; // How many times the name was used
        private int rank; // Popularity rank of the name

        public NameCount(int aCount, int aRank) {
            count = aCount;
            rank = aRank;
        }

        public int getCount() {
            return count;
        }

        public int getRank() {
            return rank;
        }
    }
}
