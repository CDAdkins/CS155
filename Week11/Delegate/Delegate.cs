/// Week 11 Lab 1
/// File Name: Delegate.cs
/// @author: Chris Adkins
/// Date: 11/22/21
///
/// Problem Statement: This program creates a delegate and two methods. It then points the delegate at each function and calls it.
/// 
/// Overall Plan
/// 1. Create a delegate.
/// 2. Create two methods that print different messages to the console.
/// 3. Point the delegate to the first method and call it. Once that is done do the same to the second method.
///
/// Classes Needed and Purpose: 
/// Main Class: Functionality is all contained in main().

using System;

namespace Delegate {
    class Delegate {
        // Creating our delegate
        public delegate void myDelegate();

        static void Main(string[] args) {
            // Assigning our delegate to aMethod
            myDelegate aDelegate = aMethod;
            
            // Calling our delegate
            aDelegate();

            // Changing the method that our delegate is pointing to
            aDelegate = anotherMethod;

            // Calling our delegate again
            aDelegate();
        }

        // A simple example method
        static void aMethod() {
            Console.WriteLine("This is aMethod(), being called from aDelegate.");
        }

        // Yet another simple example method
        static void anotherMethod() {
            Console.WriteLine("This is anotherMethod() being called by aDelegate.");
        }

    }
}
