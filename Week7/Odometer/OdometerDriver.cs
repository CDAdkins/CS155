/// Week 7 Homework 1
/// File Name: Odometer.cs
/// @author: Chris Adkins
/// Date: 10/25/21
///
/// Problem Statement: This program tracks fuel usage and miles per gallon via an Odometer class.
/// 
/// Overall Plan
/// 1. Create an odometer class with two instance variables, miles driven and fuel used.
/// 2. Create getters and setters, a method to reset miles driven and fuel used to 0, a method to add to each variable, and a return as well as a tostring.
/// 3. Create a driver program to demonstrate the functionality of the Odometer class.
///
/// Classes Needed and Purpose: 
/// Main Class: Odometer - Class that holds the actual functionality of the program.
/// Driver Class: OdometerDriver - Class that utilizes the functionality of the Odometer class.

using System;

namespace Odometer
{
    class OdometerDriver
    {
        static void Main(string[] args) {
            // Creating two Odometer objects using each type of constructor
            Odometer odo1 = new Odometer(); // Odometer object created from a default no-arg constructor
            Odometer odo2 = new Odometer(15, 200); // Odometer object created from constructor arguements to initialize variables


            // Outputting the values of each object right after creating the objects
            Console.WriteLine("\nValues Right After Creation:");
            Console.WriteLine("Odometer 1 (Default no-arg)" + odo1);
            Console.WriteLine("\nOdometer 2 (Constructor with arguments)" + odo2);

            // Using methods to manipulate the objects
            odo1.add(13, 400); // Adding 13 gallons to fuel used and 400 miles to miles driven
            odo2.reset(); // Resetting odo2

            // Printing the values of each odometer object after manipulating them with methods
            Console.WriteLine("\n\nValues After Manipulating with Methods:");
            Console.WriteLine("Odometer 1 (Default no-arg after using add method)" + odo1);
            Console.WriteLine("\nOdometer 2 (Constructor with arguments after using reset method)" + odo2);


        }
    }

    class Odometer {
        // Variables
        private double milesDriven; // Number of miles driven
        private double fuelUsed;   // Amount of fuel used in gallons

        // Constructors
        public Odometer() { // Default no-arg constructor which initializes the variables to 0
            milesDriven = 0;
            fuelUsed = 0;
        }

        public Odometer(double fuel, double miles) { // Constructor that takes two arguments and initializes the two instance variables to those values.
            fuelUsed = fuel;
            milesDriven = miles;
        }

        // Getters and Setters
        public double getMilesDriven() {
            return milesDriven;
        }

        private void setMilesDriven(double miles) { // Private because we should not be changing this value directly
            milesDriven = miles;
        }

        public double getFuelUsed() {
            return fuelUsed;
        }

        private void setFuelUsed(double fuel) { // Private because we should not be changing this value directly
            fuelUsed = fuel;
        }

        // Other Methods
        public void reset() {    // Reset both fuelUsed and milesDriven to 0
            setFuelUsed(0);     // Calling our fuelUsed setter with the argument of 0 in order to 'reset' the value
            setMilesDriven(0); // Same process used for fuelUsed above
        }

        public void add(double addFuel, double addMiles) {
            setFuelUsed(getFuelUsed() + addFuel);         // Setting the value of fuelUsed to the current value of fuelUsed + the argument called addFuel
            setMilesDriven(getMilesDriven() + addMiles); // Same as above but for milesDriven
        }

        public double mpg() { // Method to return the miles per gallon given the fuelUsed and milesDriven
            return Math.Round(getMilesDriven() / getFuelUsed(), 2);
        }

        public override String ToString() { // Easy way to print all of the relevant information about this object to the console.
            return "\nMiles Driven: " + getMilesDriven() + "\nFuelUsed: " + getFuelUsed() + "\nMiles Per Gallon: " + mpg();
        }
    }
}
