/// Week 10 Homework 1
/// File Name: AlienGame.cs
/// @author: Chris Adkins
/// Date: 11/15/2021
///
/// Problem Statement: This program makes improvements upon some given code, making the code more object oriented friendly. 
/// 
/// Overall Plan
/// 1. Split the code into multiple files, one for the ALien classes, one for the AlienPack and one more for the driver class.
/// 2. Create a new sub class for each type of Alien rather than using ints to determine the type.
/// 3. Set each instance variable for the aliens to protected rather than public. Create a getter for damage so we can access it.
/// 4. Rewrite the calculateDamage method to use the getter for damage we created earlier.
///
/// Classes Needed and Purpose: 
/// Main Class: Alien - Holds the data for the Alien class and all of its subclasses
/// Driver Class: AlienGame - Uses the methods written in the other two files to showcase their functionality to the user.
/// Other Class: AlienPack - Holds a collection of aliens and keeps track 

using System;

namespace AlienGame {
    class AlienGame {
        static void Main(string[] args) { // Alien Driver Class
            AlienPack aPack = new AlienPack(5); // Creating a new AlienPack with 5 slots
            // Individually creating aliens with their respective default no-arg constructors
            aPack.addAlien(new SnakeAlien(), 0);
            aPack.addAlien(new SnakeAlien(), 1);
            aPack.addAlien(new OgreAlien(), 2);
            aPack.addAlien(new MarshmallowManAlien(), 3);
            aPack.addAlien(new MarshmallowManAlien(), 4);

            // Printing the aliens to showcase the contents of the alien pack and their total damage
            foreach (Alien a in aPack.getAliens()) {
                Console.WriteLine(a);
            }
            Console.WriteLine("Alien Pack Total Damage: " + aPack.calculateDamage());
        }
    }
}
