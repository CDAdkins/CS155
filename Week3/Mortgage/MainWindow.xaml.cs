/// Week 3 Homework 1
/// File Name: MainWindow.xaml.cs
/// @author: Chris Adkins
/// Date: 9/20/21
///
/// Problem Statement: This is a GUI to calculate mortgage payments given an interest rate, balance, and a monthly payment
/// 
/// Overall Plan
/// 1. Declare variables to hold values of interest rates, remaining balance and monthly payments.
/// 2. Get input from user to populate the values of our relevant variables.
/// 3. On user input, simulate a monthly payment using our interest rate, balance, and payment.
///
/// Classes Needed and Purpose: 
/// Main Class: Initializes Variables and holds classes.
/// calculatePayment: Performs calculation relevant to determining how much of our payment goes towards principle / interest and updates the relevant values.
/// updateLabels: Updates our GUI labels to reflect the values of our variables.
/// updateValuesButton_Click: Updates our variables based on user input.
/// makePaymentButton_Click: Calls functions to simulate a monthly payment.

using System;
using System.Windows;


namespace Mortgage
{
    public partial class MainWindow : Window
    {
        // Constant values that never change
        const double ANNUAL_RATE = .0639; // The annual interest rate
        const double MONTHLY_RATE = ANNUAL_RATE / 12; // The monthly interest rate

        double balance = 0; // How much is still owed
        double payment = 0; // How much this month's payment will be
        double interestPaid = 0; // How much of the payment will go towards interest
        double principle = 0; // How much of the payment will go towards the principle

        public void calculatePayment() { // Method to do the math to get interest and principle paid
            interestPaid = balance * MONTHLY_RATE;
            principle = payment - interestPaid;
            balance -= principle;
        }

        public void updateLabels() { // Method to update the GUI labels (Text Boxes)
            balanceTextBlockValue.Text = balance.ToString();
            paymentTextBlockValue.Text = payment.ToString();
            interestPaidTextBlockValue.Text = interestPaid.ToString();
            principleTextBlockValue.Text = principle.ToString();
        }

        public MainWindow() {
            InitializeComponent();
            // Since these labels never change I'm only updating them on initialization
            annualRateTextBlockValue.Text = (ANNUAL_RATE * 100).ToString() + "%";
            monthlyRateTextBlockValue.Text = (MONTHLY_RATE * 100).ToString() + "%";
        }

        private void updateValuesButton_Click(object sender, RoutedEventArgs e) {
            // When this button is clicked it uses the values entered in the respective boxes to update the variables below
            balance = Double.Parse(balanceTextBox.Text);
            payment = Double.Parse(paymentTextBox.Text);
            updateLabels();
        }

        private void makePaymentButton_Click(object sender, RoutedEventArgs e) {
            balanceTextBox.Visibility = Visibility.Hidden; // Hide the balance textBox to prevent changing the balance after making the first payment.
            calculatePayment(); // Call the method to get interest paid and principle
            updateLabels(); // Update the labels with the new information
        }
    }
}
