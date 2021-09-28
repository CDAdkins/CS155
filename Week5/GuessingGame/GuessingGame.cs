/// Week 5 Lab 1
/// File Name: GuessingGame.cs
/// @author: Chris Adkins
/// Date: 9/2721
///
/// Problem Statement: This program generates a random number between 0 and 100, it then allows the user to try to guess the number and reports back whether they were too high, low of correct
/// 
/// Overall Plan
/// 1. Create variables for the number we're trying to guess, the the user's guess and the number of guesses.
/// 2. Take input from the user to initialize the guess variable. 
/// 3. Compare the user's guess to the random number and report the results back
/// 4. If the guess is wrong, repeat steps 2-3 until they get it right.
///
/// Classes Needed and Purpose: 
/// Main Class: Everything in main

using System;

namespace GuessingGame
{
    class GuessingGame
    {
        static void Main(string[] args) {
            Random randy = new Random(); // Random object
            int secretNumber;           // The number the user is trying to guess
            int numGuesses = 0;        // Number of guesses before the correct number was guessed
            int guess;                // User's guess

            secretNumber = randy.Next(0, 100);

            Console.WriteLine("Welcome to the Guess-O-Matic 6000\n---------------------------------");
            
            // Loop that will run until the correct number is guessed
            while (true) { // Technically an infinite loop but we do have a break statement acting as a sentinal
                Console.Write("\nEnter a guess from (0 - 100): ");
                guess = Int32.Parse(Console.ReadLine()); // Getting the input from the user
                numGuesses++; // Incrementing the number of guesses
                
                // Decision tree based on user input vs secret number
                if (guess > secretNumber) { // If too high
                    Console.WriteLine("Too High! Try Again.");
                } else if (guess < secretNumber) { // If too low
                    Console.WriteLine("Too Low!, Try Again.");
                } else { // If the correct number is guessed
                    Console.WriteLine("\nWOOHOO! YOU GOT IT!\nNumber of Guesses: " + numGuesses);
                    break; // Break to escape the hellscape of the infinite loop
                }
            }

            

            
        }
    }
}
