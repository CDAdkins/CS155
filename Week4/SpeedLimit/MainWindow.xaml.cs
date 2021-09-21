/// Week 4 Lab 1
/// File Name: MainWindow.xaml.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: This program takes a speed limit and a current speed. It then changes the color of the GUIs background depending on the speeds given.
/// 
/// Overall Plan
/// 1. Create variables for speed limit, current speed, and the penalty
/// 2. Get input from the user
/// 3. Use if statements to decide what color to set the background to.
///
/// Classes Needed and Purpose: 
/// Main Class: Holds variables
/// checkSpeed: Checks current speed against the speed limit and makes decisions based on the values.
/// ButtonClick: Updates our variables based on user input, makes our penalty label visible.

using System;
using System.Windows;
using System.Windows.Media;

namespace SpeedLimit
{
    public partial class MainWindow : Window
    {
        // Initializing our variables
        int speedLimit; // The speed limit
        int currentSpeed; // The speed you are currently going

        public void checkSpeed() {
            if (currentSpeed <= speedLimit) { // If our speed is less than or equal to the speed limit
                myCanvas.Background = Brushes.Green; // Make our background Green
                penaltyLabel.Content = "Not Speeding";
            } else if (currentSpeed < speedLimit + 5) { // If our speed is less than 5mph over the limit
                myCanvas.Background = Brushes.Yellow; // Make our Background Yellow
                penaltyLabel.Content = "Speeding a Bit";
            } else { // If our speed is 5 or more mph over the limit
                myCanvas.Background = Brushes.Red; // Make our Background Red
                penaltyLabel.Content = "Speeding Too Much";
            }
        }

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) { // When our check speed button is clicked
            // Update our variables based on user input in text boxes
            speedLimit = Int32.Parse(speedLimitTextBox.Text);
            currentSpeed = Int32.Parse(currentSpeedTextBox.Text);

            // Call our method to check the speed with the updated variables
            checkSpeed();
            penaltyLabel.Visibility = Visibility.Visible;
        }
    }
}
