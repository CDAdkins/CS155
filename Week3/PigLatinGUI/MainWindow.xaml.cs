/// Week 3 Lab 1
/// File Name: PigLatinGUI.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: 
/// This program takes a first and last name and converts it into Pig Latin, but now in GUI!
/// 
/// Overall Plan
/// 1. Get input from user for names
/// 2. Create substring starting with the character of each name at index 1
/// 3. Capitalize the letter at index one then add the index 0 letter to the end of the name, lowercase and add "ay"
/// 4. Wait for user to press button to display results

using System;
using System.Windows;

namespace PigLatinGUI
{
    public partial class MainWindow : Window
    {
        // Declaring our variables
        string first;      // First name before conversion
        string last;      // Last name before conversion
        string firstPig; // First name post conversion
        string lastPig; // Last name post conversion



        public void convertName() {
            // Converting the first and last name into Pig Latin
            // First we take the second letter of each name and use ToUpper to capitalize it, then we take the remainder of the name and concatenate it to the first letter.
            // We then take the first letter of each name, make it lowercase, then add it to the end of the string. We then add "ay" to the end of the string.
            firstPig = first[1].ToString().ToUpper() + first.Substring(2) + first[0].ToString().ToLower() + "ay";
            lastPig = last[1].ToString().ToUpper() + last.Substring(2) + last[0].ToString().ToLower() + "ay";
        }

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) { // Code to be run once the button is pressed
            // Initializing Variables w/ user input
            first = firstNameTextBox.Text;
            last = lastNameTextBox.Text;

            // Calling the method to convert the name into pig latin
            convertName();

            // Changing our label to the result of the name conversion, as well as making it visible.
            pigLatinNameLabel.Content = (firstPig + " " + lastPig);
            pigLatinNameLabel.Visibility = Visibility.Visible;
        }
    }
}
