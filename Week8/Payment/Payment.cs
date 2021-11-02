/// Week 8 Lab 1
/// File Name: Payment.cs
/// @author: Chris Adkins
/// Date: 11/1/21
///
/// Problem Statement: This program demonstrates base and subclass interaction using a base call of Payment and sub classes called Cash and Credit Payment.
/// 
/// Overall Plan
/// 1. Create base class called Payment with an instance variable for payment and a ToString equivalent called PaymentDetails. Also getters and setters.
/// 2. Create sub class for both cash payment and credit payment, each with slight differences from the base class.
/// 3. Create a driver class to demonstrate the differences between the base and sub classes.
///
/// Classes Needed and Purpose: 
/// Main Class: Payment - Base Ckass, CashPayment - Sub class for cash payments, CardPayment - Sub Class for ceredit / debit payments, PaymentDriver - Demo class.

using System;

namespace Payment {
    class PaymentDriver {
        static void Main(string[] args) {
            // Creating three examples for each class
            CardPayment cardPay = new CardPayment(1289.99, "Willie Nelson", "4200 6969 8008 1985"); // Card Payment object.
            CashPayment cashPay = new CashPayment(311.11);    // CashPayment object with an argument of 311
            Payment basePay = new Payment(296.99);        // Base payment object with an argument of 296.99  

            // Printing each payment object using PaymentDetails()
            Console.WriteLine("Base Class" + basePay.PaymentDetails());
            Console.WriteLine("\nCash Pay Class" + cashPay.PaymentDetails());
            Console.WriteLine("\nCard Pay Class" + cardPay.PaymentDetails());
        }
    }

    class Payment {
        // Instance Variables
        protected double amount; // Amount that is being paid, protected to enable access to sub classes

        // Constructors
        public Payment() { // Default No Arg
            amount = 0; // Defaults to a payment of $0
        }

        public Payment(double anAmount) {
            amount = anAmount; // Setting the payment amount equal to the argument
        }

        // Getters and Setters
        public double getAmount() { // Returns the value of amount
            return amount;
        }

        private void setAmount(double anAmount) { // Sets amount equal to the argument
            amount = anAmount;
        }

        // Other Methods
        public String PaymentDetails() { // Basically a ToString(), just returns a string describing the payment.
            return "\nAmount Paid: $" + amount;
        }
    }

    class CashPayment : Payment { // Sub class of the Payment class, specifically for cash payments
        // Constructors
        public CashPayment() { // Default No Arg
            amount = 0; // Defaults to a payment of $0
        }

        public CashPayment(double anAmount) {
            amount = anAmount; // Setting the payment amount equal to the argument
        }

        public new String PaymentDetails() { // Printing details of payment
            return "\nAmount Paid in Cash: $" + amount;
        }
    }

    class CardPayment : Payment {
        // Instance Variables (the double for amount is already accounted for in the base class)
        String name; // Name of Cardholder
        String cardNumber; // Number on card, string because it is not meant to be treated as a number for any arithmetic.

        // Constructors
        public CardPayment() { // Default No Arg
            amount = 0; // Defaults to a payment of $0
            name = "Paul Bunyan"; // Random default name
            cardNumber = "0000 0000 0000 0000"; // Default card number
        }

        public CardPayment(double anAmount, String aName, String aCardNumber) {
            amount = anAmount; // Setting the payment amount equal to the argument
            name = aName; // Setting the name according to the argument
            cardNumber = aCardNumber; // Setting the card number according to the argument
        }

        // Other Methods
        public new String PaymentDetails() { // More detailed description of the payment
            return "\nName: " + name + "\nCard Number: " + cardNumber + "\nAmount Spent: $" + amount;
        }
    }
}
