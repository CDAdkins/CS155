/// Week 7 Lab 1
/// File Name: Pizza.cs
/// @author: Chris Adkins
/// Date: 10/25/21
///
/// Problem Statement: This is a class that contains information about a pizza stored in a class.
/// 
/// Overall Plan
/// 1. Create a Pizza Class
/// 2. Create instance variables for size, amount of cheese, number of pepperoni toppings and number of ham toppings.
/// 3. Create getters, setters, constructors, toString and a function to calculate the cost of the pizza based on size and toppings.
///
/// Classes Needed and Purpose: 
/// Main Class: Pizza contains all of the useful data and functions. The PizzaDriver showcases those methods to the user.

using System;

namespace Pizza
{
    class PizzaDriver
    {
        static void Main(string[] args) {
            Pizza pizza1 = new Pizza(); // Default pizza, small w/ normal amount of cheese
            Pizza pizza2 = new Pizza("large", 3, 3, 1);
            Console.WriteLine("Default no-arg Pizza\n" + pizza1);
            Console.WriteLine("\nFull Constructor Pizza:\n" + pizza2);
        }
    }

    class Pizza
    {
        // Instance Variables
        private string size; // either small, medium, or large
        // Since toppings are hard to quantify 0 = no topping 1 = light topping, 2 = medium amount of topping, 3 = extra topping.
        private int cheese;
        private int pepperoni;
        private int ham;

        // Constructors
        public Pizza() { // Default no-arg, small pizza, medium cheese, no other toppings
            size = "small";
            cheese = 2;
            pepperoni = 0;
            ham = 0;
        }

        // Constructor with total control over what kind of pizza is being created
        public Pizza(string aSize, int aCheese, int aPepperoni, int aHam) {
            size = aSize;
            cheese = aCheese;
            pepperoni = aPepperoni;
            ham = aHam;
        }

        // Getters and Setters
        public string getSize() {
            return size;
        }

        private void setSize(string aSize) {
            size = aSize;
        }

        public int getCheese() {
            return cheese;
        }

        private void setCheese(int aCheese) {
            cheese = aCheese;
        }

        public int getPepperoni() {
            return pepperoni;
        }

        private void setPepperoni(int aPepperoni) {
            pepperoni = aPepperoni;
        }

        public int getHam() {
            return ham;
        }

        private void setHam(int aHam) {
            ham = aHam;
        }

        // Other Methods
        public double calculateCost() {
            double cost = 0;
            int totalToppings; // total value of all toppings.
            // Getting base cost of pizza from the size
            if (size == "large") {
                cost += 14;
            } else if (size == "medium") {
                cost += 12;
            } else { // If small or if given an invalid size
                cost += 10;
            }

            totalToppings = cheese + pepperoni + ham; // Getting total amount of toppings
            // Cost of toppings are $2 each, so we multiply the number of toppings by 2 to get the cost of toppings, then add that to the total cost.
            cost += totalToppings * 2;
            return cost;
        }

        public override string ToString() {
            string returnValue = "Pizza Size: " + size; // String we will be adding to and eventually returning
            int topping; // Reference to the value of the topping I want the value of

            // Converting the numbers for each topping into a less confusing format, Might be overengineering this.
            for (int i = 0; i < 3; i++) { // For loop to avoid typing the same code for each topping, runs once per topping
                if (i == 0) {
                    topping = cheese;
                    returnValue += "\nCheese: ";
                } else if (i == 1) {
                    topping = pepperoni;
                    returnValue += "\nPepperoni: ";
                } else {
                    topping = ham;
                    returnValue += "\nHam: ";
                }

                // Determining how to describe the amount of each topping the customer got.
                switch (topping) { // Basically converting the int value to a description of how much of a topping the customer is gettingv
                    case 0:
                        returnValue += "None";
                        break;

                    case 1:
                        returnValue += "Light";
                        break;

                    case 2:
                        returnValue += "Normal";
                        break;

                    case 3:
                        returnValue += "Extra";
                        break;
                }
            }

            returnValue += "\nCost of Pizza: $" + calculateCost(); // Adding cost to the return string
            return returnValue;
        }
    }
}
