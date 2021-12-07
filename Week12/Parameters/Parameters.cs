/// Week 12 Lab 1
/// File Name: Parameters.cs
/// @author: Chris Adkins
/// Date: 12/6/2021
///
/// Problem Statement: This program gives an example of optional, named, and variable parameters.
/// 
/// Overall Plan
/// 1. Create a mathod with an optional parameter that ha a default value that can be overwritten.
/// 2. Create a method with parameters and call the method using named parameters to pass the parameters in a different order.
/// 3. Create a method with a variable number of parameters using an array as a parameter.
///
/// Classes Needed and Purpose: 
/// Main Class: Contains all of the methods and logic to call them.

using System;

namespace Parameters {
    class Parameters {
        static void Main(string[] args) {
            // Optional Parameter Demo
            aMethod();
            aMethod("Non-default parameter");

            Console.WriteLine();

            // Named Parameters Demo
            anotherMethod(three:1, two:2, one:3);
            anotherMethod(1, 2, 3);

            // Variable Number of Parameters Demo
            average(1, 2, 4, 6, 4, 10);
            average(7, 8, 9, 10);
            average(12, 355, 45);
        }

        // Optional Parameter Method
        static void aMethod(string aParameter = "Default Parameter") {
            Console.WriteLine(aParameter);
        }

        // Named Parameter Method
        static void anotherMethod(int one, int two, int three) {
            Console.WriteLine("one: " + one + "\ntwo: " + two + "\nthree: " + three + "\n");
        }

        // Variable Number of Parameters Method
        static void average(params int[] numbers) {
            double total = 0;
            foreach (int number in numbers) {
                total += number;
            }
            Console.WriteLine(Math.Round(total / (double)numbers.Length, 2));
        }
    }
}
