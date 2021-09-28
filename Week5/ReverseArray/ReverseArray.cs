/// Week 5 Homework 2
/// File Name: ReverseCopy.cs
/// @author: Chris Adkins
/// Date: 9/27/21
///
/// Problem Statement: This program creates an array, then reverses and copies the contents of that array into a new array.
/// 
/// Overall Plan
/// 1. Initialize a new array and fill it with some values.
/// 2. Create a new array with nothing in it.
/// 3. Use a for loop to walk through the array backwards and individually move each element into the empty array.
/// 4. Print resulting array to user.
///
/// Classes Needed and Purpose: 
/// Main Class: Everything is in main 

using System;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args) {
            int[] originalArray = new int[] { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }; // The array we will be copying from
            int[] reverseArray = new int[originalArray.Length]; // the array we will be copying to

            for (int i = 0; i < originalArray.Length; i++) { // For loop that will loop once per element in the original array
                reverseArray[i] = originalArray[originalArray.Length - 1 - i]; // Set reverseArray[i] equal to the element at index originalArray.Length - i. 
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

            // Printing the reversed array, this is nearly identical to the loop used to print the original array
            Console.WriteLine("\n\nReveresed Array: ");
            for (int i = 0; i < reverseArray.Length; i++) {
                if (i < reverseArray.Length - 1) { // If we are not printing the last element in the array, include a comma after the element
                    Console.Write(reverseArray[i] + ", ");
                } else { // If we are printing the last element in the array then there is no need to include the comma
                    Console.Write(reverseArray[i]);
                }
            }
        }
    }
}
