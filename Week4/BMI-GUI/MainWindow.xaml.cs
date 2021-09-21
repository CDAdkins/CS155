/// Week 4 Homework 1
/// File Name: MainWindow.xaml.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: This is a GUI BMI calculator that takes a height and weight and returns your BMI.
/// 
/// Overall Plan
/// 1. Create variables for height, weight, and BMI
/// 2. Take input from the user
/// 3. Update the variables with the user input and calculate BMI
/// 4. Change the GUI to reflect results of BMI calculations
///
/// Classes Needed and Purpose: 
/// Main Class: 

using System;
using System.Windows;
using System.Windows.Media;


namespace BMI_GUI
{
    public partial class MainWindow : Window
    {
        double height;
        double weight;
        double BMI;

        public void calculateBMI() { // Method to calculate BMI using the given formula.
            BMI = (weight * 720) / (height*height);
            BMI = Math.Round(BMI, 2); // Rounding to keep our number clean
        }

        public void updateGUI() {
            // Changing the canvas color and the BMI label
            if (BMI < 15) { // If BMI is lower than healthy
                BMILabel.Content = "BMI: " + BMI + " - Underweight";
                myCanvas.Background = Brushes.Blue;
            } else if (BMI <= 26) { // If BMI is within healthy range
                BMILabel.Content = "BMI: " + BMI + " - Healthy Weight";
                myCanvas.Background = Brushes.Green;
            } else { // If BMI is above healthy range
                BMILabel.Content = "BMI: " + BMI + " - Overweight";
                myCanvas.Background = Brushes.OrangeRed;
            }
        }

        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) { // When calculate BMI button is pressed
            // Update our variables from user input
            weight = Double.Parse(weightTextBox.Text);
            height = Double.Parse(heightTextBox.Text);

            // Call our methods for calculating BMI and updating the GUI
            calculateBMI();
            updateGUI();
        }
    }
}
