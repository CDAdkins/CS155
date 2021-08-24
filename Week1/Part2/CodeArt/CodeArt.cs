/// Homework No. 1 Excercise No. 2
/// File Name: CodeArt.cs
/// @author: Chris Adkins
/// Date: 8/23/2021
///
/// Problem Statement: 
/// This code prints a tree using Console.WriteLine()
/// Overall Plan
/// 1. Write a Console.WriteLine statement
/// 2. Repeat as necessary, changing the number of spaces and '*' until the output resembles a tree.
///
/// Classes Needed and Purpose: 
/// Main Class: CodeArt - Contains all of the WriteLine() calls.
/// Console.WriteLine() Used to print the text to the console.
///

using System;

namespace Week1
{
    class CodeArt
    {
        static void Main(string[] args) {
            Console.WriteLine("          *");
            Console.WriteLine("         * *");
            Console.WriteLine("        *   *");
            Console.WriteLine("       **   **");
            Console.WriteLine("        *   *");
            Console.WriteLine("      **     **");
            Console.WriteLine("     ***     ***");
            Console.WriteLine("       *     *");
            Console.WriteLine("     **       **");
            Console.WriteLine("   *****     *****");
            Console.WriteLine("        *   *");
            Console.WriteLine("        *   *");
            Console.WriteLine("        *   *");
            Console.WriteLine("        *****");
        }
    }
}