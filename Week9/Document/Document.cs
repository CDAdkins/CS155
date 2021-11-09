/// Week 9 Lab 1
/// File Name: Document.cs
/// @author: Chris Adkins
/// Date:11/8/21
///
/// Problem Statement: This program creates a base class as well as two sub classes that both inherit variables and overload methods from the base class.
/// 
/// Overall Plan
/// 1. Create base class called Document with a variable to store a string.
/// 2. Create two sub classes, Email which includes additional instance variables and File which includes a single additional instance variable.
/// 3. Create a driver class to demonstrate the differences between the three classes.
///
/// Classes Needed and Purpose: 
/// Main Class: Document, base class for Email and File.
/// Sub Classes: File and Email, Subclasses of Document with additional instance variables and modified methods.
/// Driver Class: DocumentDriver, Demonstrates the functionality of the three classes. 

using System;

namespace Document {
    class DocumentDriver {
        static void Main(string[] args) {

            Email email1 = new Email();
            Email email2 = new Email("Have you lost your mind? The CIA want me to launch a retaliatory strike, a blockade is the only way this ends peacefully.", 
                                     "John F. Kennedy", "Fidel Castro", "What are you doing?");
            File file1 = new File();
            File file2 = new File("2+2=4", "C:/Users/billy/Documents/Mathquiz.txt");

            static bool ContainsKeyword(Document docObject, string keyword) { // Provided parser method
                if (docObject.ToString().IndexOf(keyword, 0) >= 0) {
                    return true;
                }
                return false;
            }

             // Passing each object through a parser that checks for the word, "hello"
            // email1 and file1 should be true because they use the default text which includes "hello"
            Console.WriteLine(ContainsKeyword(email1, "Hello"));
            Console.WriteLine(ContainsKeyword(email2, "Hello"));
            Console.WriteLine(ContainsKeyword(file1, "Hello"));
            Console.WriteLine(ContainsKeyword(file2, "Hello"));
        }
    }

    class Document {
        // Instance Variables
        protected string text;

        // Constructors
        public Document() { // Default No Arg
            text = "Hello. Goodbye!";
        }

        public Document(string aText) { // Constructor with argument
            text = aText;
        }

        // Getters and Setters
        private void setText (string aText) {
            text = aText;
        }

        // Other Methods
        public override string ToString() {
            return text;
        }
    }

    class Email : Document {
        // Instance Variables
        private string sender, recipient, title;

        // Constructors
        public Email() { // Default No Arg
            sender = "Bradley Nowell";
            recipient = "Eric Wilson";
            title = "New Lyrics";
            text = "Hello!";
        }
        
        public Email(string aText, string aSender, string aRecipient, string aTitle) { // Constructor with argument
            text = aText;
            sender = aSender;
            recipient = aRecipient;
            title = aTitle;
        }

        // Getters and Setters
        public string getSender() {
            return sender;
        }

        private void setSender(string aSender) {
            sender = aSender;
        }

        public string getRecipient() {
            return recipient;
        }

        private void setRecipient(string aRecipient) {
            recipient = aRecipient;
        }

        public string getTitle() {
            return title;
        }

        private void setTitle(string aTitle) {
            title = aTitle;
        }

        // Other Methods
        public override string ToString() {
            return "To: " + getRecipient() + "\nFrom: " + getSender() + "\nSubject: " + getTitle() + "\n Message: " + base.ToString();
        }
    }

    class File : Document {
        // Instance Variables
        private string path;

        // Constructors
        public File() { // Default No Arg
            path = "C:/Users/rickastleyfan420/Documents/Homework/Grapefruit.mp4";
        }

        public File(string aText, string aPath) { // Constructor with arguments
            text = aText;
            path = aPath;
        }

        // Getters and Setters
        public string getPath() {
            return path;
        }

        private void setPath(string aPath) {
            path = aPath;
        }

        // Other Methods
        public override string ToString() {
            return "Path: " + getPath() + "\nText: " + base.ToString();
        }
    }

}   
