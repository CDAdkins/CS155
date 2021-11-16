/// Week 10 Lab 1
/// File Name: PhoneBook.cs
/// @author: Chris Adkins
/// Date: 11/15/2021
///
/// Problem Statement: This program is an interactive phone book with features to view, search, add and remove contacts.
/// 
/// Overall Plan
/// 1. Create a dictionary with a <string, string> format to hold a name as a key and a phone number as a value.
/// 2. Create methods for adding a contact, removing a contact, searching for a specific contact and printing the contents of the phone book.
/// 3. Create a driver class to fill the phone book and provide a manu for the user to interact with the phone book.
///
/// Classes Needed and Purpose: PhoneBook and PhoneBookDriver
/// Main Class: Phone Book: Contains the contact information and the methods to edit the contents.
/// Driver Class: Contains a menu to allow for user interation with the phone book.

using System;
using System.Collections.Generic;

namespace Phone_Book {
    class PhoneBookDriver {
        static void Main(string[] args) {
            PhoneBook myBook = new PhoneBook(); // Creating a new, empty phone book
            string input = ""; // String that handles user input
            string tempName = ""; // Temporary holder of a potential contact name
            string tempNumber = ""; // Temporary holder for potential phone number
            bool quit = false;

            // Adding contacts to the phone book
            myBook.addContact("John Smith", "7602349745");
            myBook.addContact("Dick Tracy", "4428740368");
            myBook.addContact("Lisa Simpson", "6190367298");
            myBook.addContact("Bucky Lasek", "8587295132");
            myBook.addContact("Nyjah Huston", "7267389465");
            myBook.addContact("Big Larry", "3089778456");
            myBook.addContact("Steve Rodgers", "4585652212");
            myBook.addContact("Rick Ross", "8859823155");
            myBook.addContact("Stump Baker", "2125688845");
            myBook.addContact("Rick Harrsion", "6858215489");

            while (!quit) {
                Console.WriteLine("Phone Book Program:\n-------------------"); // Printing the menu to the user
                Console.WriteLine("1. View All Contacts\n2. Search Contacts\n3. Add a Contact\n4. Remove a Contact\n5. Quit\n");
                Console.Write("Enter your Choice: ");

                input = Console.ReadLine(); // Reading the user input

                switch(Int32.Parse(input)) {
                    case 1: // Print the contacts to the user
                        Console.WriteLine(myBook);
                        break;
                    case 2: // Search for user number by name
                        Console.Write("Enter Contact Name: ");
                        input = Console.ReadLine();
                        Console.WriteLine(myBook.findContact(input));
                        break;
                    case 3: // Adding a new contact to the phoen book given a name and number
                        Console.Write("Enter Contact Name: ");
                        tempName = Console.ReadLine();
                        Console.Write("Enter Contact Phone Number: ");
                        tempNumber = Console.ReadLine();
                        myBook.addContact(tempName, tempNumber);
                        break;
                    case 4: // Remove a contact by name
                        Console.Write("Enter Contact Name: ");
                        input = Console.ReadLine();
                        myBook.removeContact(input);
                        break;
                    case 5: // Quit Program
                        quit = true;
                        break;
                }
            }
        }
    }

    class PhoneBook {
        // Instance Variables
        Dictionary<string, string> book = new Dictionary<string, string>(); // Object containing all of the names in the phone book

        // Constructor
        public PhoneBook() {
            // Default no arg doesn't really need to do anything for this project
        }

        // Methods
        public void addContact(string name, string number) {
            book.Add(name, number); // Adds a name and phone number to the phone book.
        }

        public string findContact(string name) { // Returns a phone number based on a given name
            string temp = "";
            if (book.ContainsKey(name)) {
                temp = "" + name + ": " + book[name] + "\n";
                return temp;
            } else {
                return "Contact Not Found\n";
            }
        }

        public void removeContact(string name) { // Removes a contact given the name
            if (book.ContainsKey(name)) {
                book.Remove(name);
            } else {
                Console.WriteLine("Contact Not Found\n");
            }
        }

        public override string ToString() { // Prints a formatted list of each contact and its corresponding phone number
            string output = "Contact List:\n-------------\n";
            foreach(KeyValuePair<string, string> kvp in book) {
                output += kvp.Key + "\n" + kvp.Value + "\n\n";
            }
            return output;
        }
    }
}
