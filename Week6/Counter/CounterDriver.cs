/// Week 6 Homework 1
/// File Name: CounterDriver.cs
/// @author: Chris Adkins
/// Date: 10/11/21
///
/// Problem Statement: This program creates a class called Counter that contains methods to increment, decrement, reset, and print the status of a count.
///                    I will also be including a driver program to test and demonstrate the methods listed above.
/// 
/// Overall Plan
/// 1. Create Counter class with variables to store the current count.
/// 2. Create a function to increment the count, another to decrement the count, and a third to reset the count. We wil also need to implement a ToString and Equals method.
/// 3. Use the main method to give the user a way to interact with my Mounter class.
///
/// Classes Needed and Purpose: 
/// Main Class: CounterDriver - Handles user input and output
/// Counter: Class containing the functions required to keep track of and modify a count.

using System;

namespace Counter
{
    class CounterDriver
    {
        static void Main(string[] args) {
            Counter myCounter = new Counter(); // Creating a Counter object for my main class
            int choice; // Variable to keep track of user input
            bool stop = false; // Variable keeping track of when the user wants to quit.

            // Saying hello
            Console.WriteLine("Welcome to the COUNT-O-MATIC 3000");

            // Looping this code until the user wants to quit
            while (!stop) {
                // Talking to the user and printing a menu for interaction with each 
                Console.WriteLine("\n1. Print Current Count");
                Console.WriteLine("2. Increment Count by 1");
                Console.WriteLine("3. Decrement Count by 1");
                Console.WriteLine("4. Reset Count to 0");
                Console.WriteLine("5. Compare Count to Another Number");
                Console.WriteLine("0. Quit");
                Console.Write("Please Enter a choice (0-5): ");

                // Implementing the menu functionality based on user input
                choice = Int32.Parse(Console.ReadLine()); // Getting input from user

                // Deciding what to do once the user has made their selection
                switch(choice) {
                    case 0: // Quit
                        stop = true;
                        break;
                    case 1: // Print Count
                        Console.WriteLine(myCounter);
                        break;
                    case 2: // Increment Count
                        myCounter.increment();
                        break;
                    case 3: // Decrement Count
                        myCounter.decrement();
                        break;
                    case 4: // Reset Count
                        myCounter.reset();
                        break;
                    case 5: // Compare Count
                        Console.Write("Enter the number you'd like to compare the count to: ");
                        choice = Int32.Parse(Console.ReadLine()); // Getting the number to compare the count to
                        if (myCounter.Equals(choice)) { // If the number entered is equal to our count
                            Console.WriteLine("The count is equal to {0}!", choice);
                        } else { // If the number entered is not equal to our count
                            Console.WriteLine("The count is not equal to {0}!", choice);
                        }
                        break;
                }
            }
        }
    }

    public class Counter
    {
        private int count = 0; // Variable to store the current count, will always be initialized to 0 upon instantiation. Private to stop unwanted modification

        // Function to access the current value of the count variables without being able to modify it directly
        public int getCount() {
            return count;
        }

        // Function to reset the count to 0
        public void reset() {
            count = 0; // sets the count to 0
        }

        // Function to increment the count by 1
        public void increment() {
            count++; // increments the count by 1
        }

        // Function to decrement the count by 1
        public void decrement() {
            if (count > 0) { // Checking to see if the count is greater than 0 here prevents the count becoming negative.
                count--; // decrements the count by 1, provided the statement above is true
            }
        }

        // Function to override the existing ToString function
        public override String ToString() {
            return ("The count is currently: " + count); // Returns a simple string telling the user the count.
        }

        // Function to compare the value of our count to another int.
        public bool Equals(int otherNum) {
            if (otherNum == count) { // If the argument passed into out function is equal to this objects count
                return true; // Then we are equal
            } else {
                return false; // If we get here then we are not equal
            }
        }
    }
}
