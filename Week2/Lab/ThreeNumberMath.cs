/// Week 2 Lab 1
/// File Name: ThreeNumberMath.cs
/// @author: Chris Adkins
/// Date: 8/30/2021
///
/// Problem Statement: This program expands upon the homework from last week by increasing the number of variables and operations.
/// 
/// Overall Plan
/// 1. Declare our variables
/// 2. Get input from the user to initialize the variables to the desired values
/// 3. Perform the desired operations on the variables
/// 4. Print the results of the operations to the user


using System;

namespace Lab1
{
    class ThreeNumberMath
    {
        static void Main(string[] args) {
            // Print a welcome message to the screen
            Console.WriteLine("WELCOME TO THE NUMBER ADDER-DIVIDER-MULTIPLIER 3000.");

            // Declare our variables
            int n1, n2, n3, sum, product, quotient, remainder;
            float floatQuotient;

            // Initializing our variables with user input
            Console.Write("Please enter the first number: ");
            n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            n2 = Int32.Parse(Console.ReadLine());
            Console.Write("Please Enter the third number: ");
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum, quotient, and product of the n1, n2, and n3 variables
            sum = n1 + n2 + n3;
            product = n1 * n2 * n3;
            quotient = product / sum;
            remainder = product % sum;
            floatQuotient = (float)product / sum;

            // Print the results of the operations above
            Console.WriteLine("The sum of those three numbers is {0}", sum);
            Console.WriteLine("The product of those numbers is {0}", product);
            Console.WriteLine("The product divided by the product is {0} remainder {1}, or {2}", quotient, remainder, floatQuotient);
        }
    }
}
