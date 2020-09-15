/*
 * Homework No. 2 Excercise No. 1
 * File Name: PigLatin.cs
 * @author: Chris Adkins
 * Date: Sep. 14, 2020
 * 
 * Problem Statement: This code converts a sentence into Pig Latin.
 * 
 * Overall Plan:
 * 1. Get some input from the user.
 * 2. Create a function to convert the input from the user into Pig Latin.
 *      a. Create a foreach loop for every word in the user's input.
 *      b. Create variables for the first and second letter as well as the rest of the word for each word.
 *      c. Use substrings to separate these parts of each word.
 *      d. Create a new string by placing the second letter first, the rest of the word second, and the first letter last.
 *      e. Append an "ay" to the end of the string.
 * 3. Print the resulting string to theuser.
 */

using System;

namespace Homework2 {

    class PigLatin {
        public static void Main(string[] args) {
            // Getting input from the user.
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            // Calling our PigLatin function.
            string pigLatin = convertToPigLatin(sentence);

            // Printing the resulting string to the user.
            Console.WriteLine(pigLatin);
        }

        private static string convertToPigLatin(string sentence) {
            // Variable to hold our new sentence.
            string returnSentence = "";

            // Loop to iterate over each word in our sentence.
            foreach (string word in sentence.Split()) {
                string firstLetter = word.Substring(0, 1);
                string secondLetter = word.Substring(1, 1);
                string restOfWord = word.Substring(2, word.Length - 2);

                // Rearranging the letters into Pig Latin order.
                returnSentence += secondLetter.ToUpper() + restOfWord + firstLetter.ToLower() + "ay ";
            }
            return returnSentence;
        }
    }
}