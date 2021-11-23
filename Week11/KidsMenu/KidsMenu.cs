/// Week 11 Homework 1
/// File Name: KidsMenu
/// @author: Chris Adkins
/// Date: 11/22/21
///
/// Problem Statement: This program creates a person class and creates a list of people. It then sorts the list based on a given characteristic.
/// 
/// Overall Plan
/// 1. Create a Person class
/// 2. Create a list of 10 people
/// 3. Sort the list in to < 12 and >= 12 groups. Then calculate the average height and list those who are taller.
///
/// Classes Needed and Purpose: 
/// Main Class: KidsMenu - Handles creating and parsing the list of people
/// Other Class: Person  - Class for the Person object, it has basic functionality and some instance variables.

using System;
using System.Collections.Generic;
using System.Linq;

namespace KidsMenu {
    class KidsMenu {
        static void Main(string[] args) {
            int averageHeight = 0; // Number to keep track of our average height

            List<Person> people = new List<Person>();

            people.Add(new Person());
            people.Add(new Person("Dick Enberg", 76, 70));
            people.Add(new Person("Wendy Williams", 34, 65));
            people.Add(new Person("Brendan Bender", 12, 55));
            people.Add(new Person("Steve Garrison", 10, 45));
            people.Add(new Person("Peter Wells", 7, 46));
            people.Add(new Person("Carol Rocha", 10, 50));
            people.Add(new Person("Xavier Watts", 13, 56));
            people.Add(new Person("Dana Garza", 16, 62));
            people.Add(new Person("Candice Brown", 8, 42));


            Console.WriteLine("People Eligible for the Kids Menu:\n");
            // Calculating average height and printing those who are 12 or younger.
            foreach (Person a in people) {
                averageHeight += a.getHeight();
                if (a.getAge() <= 12) {
                    Console.WriteLine(a);
                }
            }

            Console.WriteLine("\nPeople Taller than the Average Height of " + averageHeight + " inches\n");
            averageHeight /= people.Count;

            // Query to find those who are taller than the average height
            IEnumerable<Person> results = from a in people where a.getHeight() > averageHeight orderby a.getHeight() select a;

            foreach (Person a in results) {
                Console.WriteLine(a);
            }

        }
    }

    class Person {
        // Instance Variables
        private string name;
        private int age;
        private int height; // Height in inches

        // Constructors
        // Default No-Arg
        public Person() {
            name = "Jon Snow";
            age = 34;
            height = 68;
        }

        // Constructor with arguments
        public Person(string aName, int anAge, int aHeight) {
            name = aName;
            age = anAge;
            height = aHeight;
        }

        // Getters and Setters
        public string getName() {
            return name;
        }

        public int getAge() {
            return age;
        }

        public int getHeight() {
            return height;
        }

        private void setName(string aName) {
            name = aName;
        }

        private void setAge(int anAge) {
            age = anAge;
        }

        private void setHeight(int aHeight) {
            height = aHeight;
        }

        // Other Methods
        public override string ToString() {
            return ("Name: " + getName() + "\nAge: " + getAge() + "\nHeight: " + getHeight() +" inches\n"); 
        }
    }

}
