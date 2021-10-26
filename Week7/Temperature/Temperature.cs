/// Week 7 Homework 2
/// File Name: Temperature.cs
/// @author: Chris Adkins
/// Date: 10/25/21
///
/// Problem Statement: This program demonstrates multiple constructors using an object to track temperature and scale.
/// 
/// Overall Plan
/// 1. Create a temperature class with two instance variables, temperature and scale.
/// 2. Create four constructors, one for no args, one for only the temperature arguement, one for only the scale arguement, and one for both arguments.
/// 3. Create a driver class to implement each constructor and print the results.
///
/// Classes Needed and Purpose: 
/// Main Class: Temperature holds the actual functionality of the code.
///             TemperatureDriver implements the methods from the Temperature class.

using System;

namespace Temperature
{
    class TemperatureDriver
    {
        static void Main(string[] args) {
            // Creating four Temperature objects with each of the constructors
            Temperature temp1 = new Temperature(0, 'C'); // Given both
            Temperature temp2 = new Temperature('F');    // Given only scale
            Temperature temp3 = new Temperature(23);    // Given only temperature
            Temperature temp4 = new Temperature();     // Default no-arg

            // Printing each object to the console and comparing two temperatures
            Console.WriteLine("Temperature 1: {0} \nTemperature 2: {1}\nTemperature 3: {2}\nTemperature 4: {3}", temp1, temp2, temp3, temp4);

            Console.WriteLine("Is Temperature 2 equal to Temperature 3?\nAnswer: " + temp2.Equals(temp3));
            Console.WriteLine("\nIs Temperature 1 equal to Temperature 4?\nAnswer: " + temp1.Equals(temp4));
        }
    }

    class Temperature
    {
        // Instance Variables
        private double temperature;
        private char scale; // Either Celsius or Fahrenheit

        // Constructors
        public Temperature() { // Default no-arg
            temperature = 0;
            scale = 'C';
        }

        public Temperature(double aTemp) { // Given only temperature
            temperature = aTemp;
            scale = 'C';
        }

        public Temperature(Char aScale) { // Given only scale
            temperature = 0;
            scale = aScale;
        }

        public Temperature(double aTemp, char aScale) { // Given both temperature and scale
            temperature = aTemp;
            scale = aScale;
        }

        // Getters and Setters
        public double getTemperatureFahrenheit() { // Returns the temperature in Fahrenheit. Converting based on the scale provided
            if (scale == 'F') { // If we are in Fahrenheit already, then no conversion is needed.
                return temperature;
            } else { // If celsius or not provided, we must convert to Fahrenheit.
                return Math.Round(temperature * 1.8 + 32, 2);
            }
        }

        public double getTemperatureCelsius() { // Returns the temperature in Celsius. Converting based on the scale provided
            if (scale == 'F') { // If we are in Fahrenheit, then we must convert to Celsius.
                return Math.Round((temperature - 32) / 1.8, 2);
            } else { // If celsius or not provided, no conversion is needed.
                return temperature;
            }
        }

        private void setTemperature(double aTemp) {
            temperature = aTemp;
        }

        public char getScale() {
            return Char.ToUpper(scale);
        }

        public void setScale(char aScale) {
            scale = aScale;
        }

        public void setBoth(double aTemp, char aScale) {
            temperature = aTemp;
            scale = aScale;
        }

        // Other Methods

         // Compares the scale and temp of two Temperature objects.
        // Note that this does not convert between celsius and Fahrenheit to check if the actual values are equal.
        public Boolean Equals(Temperature otherTemp) { 
            if (this.temperature == otherTemp.temperature && this.scale == otherTemp.scale) { // If temp and scale matches
                return true;
            } else { // If either variable is not the same
                return false;
            }
        }

        public override string ToString() { // Prints all relevant data to the console
            return "\nTemperature in Fahrenheit: " + getTemperatureFahrenheit() + "°\nTemperature in Celsius: " + getTemperatureCelsius() + "°\nScale: " + getScale() + "\n";
        }
    }
}
