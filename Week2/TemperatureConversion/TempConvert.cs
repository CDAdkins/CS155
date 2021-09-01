/// Week 2 Homework 2
/// File Name: TempConvert
/// @author: Chris Adkins
/// Date: 8/31/21
///
/// Problem Statement: This program converts a temperature from farenheit to celsius
/// 
/// Overall Plan
/// 1. Get input from the user
/// 2. Initialize variable for initial temp from user input
/// 3. Use provided formula C=(5(F-32)/9) to get the celsius temperature
/// 4. Use Math.Round to round converted temps to one decimal place.

using System;

namespace TemperatureConversion
{
    class TempConvert
    {
        static void Main(string[] args) {
            // Initializing Variables
            double farenheit;
            double celsius;

            // Getting input to initialize Farenheit value
            Console.Write("Enter a number to convert to Celsius: ");
            farenheit = Int32.Parse(Console.ReadLine());

            // Perform conversion using formula
            celsius = Math.Round(5 * (farenheit - 32) / 9, 1);

            // Display results to user
            Console.WriteLine("{0}°F = {1}°C", farenheit, celsius);
        }
    }
}
