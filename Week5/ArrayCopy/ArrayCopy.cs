/// Week 5 Homework 1
/// File Name: ArrayCopy.cs
/// @author: Chris Adkins
/// Date: 9/27/21
///
/// Problem Statement: This program creates an array, then copies the contents of that array into a new array.
/// 
/// Overall Plan
/// 1. Initialize a new array and fill it with some values.
/// 2. Create a new array with nothing in it.
/// 3. Use a for loop to walk through the array and individually move each element into the empty array.
/// 4. Print resulting array to user.
///
/// Classes Needed and Purpose: 
/// Main Class: Everything is in main

using System;

namespace ArrayCopy
{
    class ArrayCopy
    {
        static void Main(string[] args) {
            int[] originalArray = new int[] {1, 2, 3, 5, 8, 13, 21, 34, 55, 89}; // The array we will be copying from
            int[] copyArray = new int[originalArray.Length]; // the array we will be copying to

            for (int i = 0; i < originalArray.Length; i++) { // For loop that will loop once per element in the original array
                copyArray[i] = originalArray[i]; // Set the element at the current index of copyArray to the equivalent element (by index) in the original array
            }

            // Printing the contents of both arrays to the user
            // Printing the original array
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < originalArray.Length; i++) {
                if (i < originalArray.Length - 1) { // If we are not printing the last element in the array, include a comma after the element
                    Console.Write(originalArray[i] + ", ");
                } else { // If we are printing the last element in the array then there is no need to include the comma
                    Console.Write(originalArray[i]);
                }
            }

            // Printing the copy array, this is nearly identical to the loop used to print the original array
            Console.WriteLine("\n\nCopy Array: ");
            for (int i = 0; i < copyArray.Length; i++) {
                if (i < copyArray.Length - 1) { // If we are not printing the last element in the array, include a comma after the element
                    Console.Write(copyArray[i] + ", ");
                } else { // If we are printing the last element in the array then there is no need to include the comma
                    Console.Write(copyArray[i]);
                }
            }
        }
    }
}
