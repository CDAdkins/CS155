/// Week 6 Lab 1
/// File Name: MainWindow.xaml.cs
/// @author: Chris Adkins
/// Date: 10/11/21
///
/// Problem Statement: This program provides basic calculation of two numbers while checking to make sure the input is valid.
/// 
/// Overall Plan
/// 1. Add two boxes for the user to enter the numbers
/// 2. Give the user 5 options for different mathematical operations to perform
/// 3. Check to see that the input is valid (AKA numbers only)
/// 4. If invalid, print an error message, if valid then perform the calculations.
/// 5. Print the result of the calculations to the user.
/// 
/// Classes Needed and Purpose: 
/// Main Class: This class has everything in it.

using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator_GUI
{
    public partial class MainWindow : Window
    {
        // Var to handle what calculation is being done. (0 +, 1 -, 2 *, 3 /, 4 %)
        private int choice = -1; // Initialize to an unreachable number
        
        public MainWindow() {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
            
        }

        // Changing our choice variable depending on what has been selected by the user.
        private void add_Selected(object sender, RoutedEventArgs e) {
            choice = 0;
        }
        
        private void subtract_Selected(object sender, RoutedEventArgs e) {
            choice = 1;
        }

        private void multiply_Selected(object sender, RoutedEventArgs e) {
            choice = 2;
        }

        private void divide_Selected(object sender, RoutedEventArgs e) {
            choice = 3;
        }

        private void mod_Selected(object sender, RoutedEventArgs e) {
            choice = 4;
        }

        private void CalcClick(object sender, RoutedEventArgs e) {
            
            try { // Try block to check the following input for exceptions
                switch (choice) {
                    case 0: // If + is clicked, add left number to right number
                        result.Content = (Int32.Parse(leftTextBox.Text) + Int32.Parse(rightTextBox.Text));
                        break;
                    case 1: // If - is clicked, subtract right number from left number
                        result.Content = (Int32.Parse(leftTextBox.Text) - Int32.Parse(rightTextBox.Text));
                        break;
                    case 2: // If * is clicked, multiply the numbers
                        result.Content = (Int32.Parse(leftTextBox.Text) * Int32.Parse(rightTextBox.Text));
                        break;
                    case 3: // If / is clicked, divide left number by right number
                        result.Content = (Int32.Parse(leftTextBox.Text) / Int32.Parse(rightTextBox.Text));
                        break;
                    case 4: // If % is clicked, mod the left number by the right number
                        result.Content = (Int32.Parse(leftTextBox.Text) % Int32.Parse(rightTextBox.Text));
                        break;
                }
            } catch (FormatException) { // If the user types anything other than a number in either box
                result.Content = "invalid input"; // Change the result text
                MessageBox.Show("Enter a number pls", "You Messed Up"); // Scold the user for being bad
            }

        }


    }
}
