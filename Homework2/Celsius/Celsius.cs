/*
 * Homework No. 2, Excercise No. 2
 * File Name: Celsius.cs
 * @author: Chris Adkins
 * Date: Sep. 14, 2020
 * 
 * Problem Statement: This program converts Fahrenheit temperatures into Celsius.
 * 
 * Overall Plan:
 * 1. Get input from the user.
 * 2. Use the given formula to convert the number to celsius.
 * 3. Print the resulting number back to the user.
 */

using System;
namespace Homework2 {

    class Celsius {
        public static double getInput(string prompt) {
            Console.Write(prompt); // Asking the user for a temperature.
            return Double.Parse(Console.ReadLine()); // Reading the input from the user as a double.
        }

        public static double convertToCelsius(double fTemp) { // Utilizing the formula to convert the number.
            return (5 * (fTemp - 32) / 9);
        }

        public static void Main(string[] args) {
            // Getting our initial temperature from the user.
            double temp = getInput("Enter a tempurature in Fahrenheit: ");

            // Printing the result to the user.
            Console.WriteLine(temp + "° Fahrenheit is " + Math.Round(convertToCelsius(temp), 1) + "° " + "Celsius.");
        }
    }
}