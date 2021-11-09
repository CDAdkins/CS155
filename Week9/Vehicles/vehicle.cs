/// Week 11 Homework 1
/// File Name: vehicle,cs
/// @author: Chris Adkins
/// Date: 11/8/21
///
/// Problem Statement: This program creates a class called Vehicle and a sub class called Truck which has customer implementations of some base class methods.
/// 
/// Overall Plan
/// 1. Create Vehicle class with instance variables, constructors, getters setters, and ToString methods.
/// 2. Create sub class with additional instance variables and a new ToString() and Equals() method,
/// 3. Create a driver class to demonstrate the differences between the classes.
///
/// Classes Needed and Purpose: 
/// Main Class: Vehicle, base class for Truck
/// Sub Class: Truck, Sub Class of Vehicle
/// Driver Class: Vehicle Driver (lol), Class to demonstrate methods and constructors of each class

using System;

namespace Vehicles {



    class VehicleDriver {
        static void Main(string[] args) {
            Vehicle car1 = new Vehicle(Manufacturer.Ford, 8, new Person("Bob Dylan"));
            Vehicle car2 = new Vehicle();
            Truck truck2 = new Truck();
            Truck truck1 = new Truck(Manufacturer.Toyota, 6, new Person("Joe Dirt"), 500, 600);

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(truck1);
            Console.WriteLine(truck2);

            Console.WriteLine(truck1.Equals(truck2));
            Console.WriteLine(truck1.Equals(truck1));
        }
    }

    class Vehicle {
        // Instance Variables
        protected Manufacturer man; // Representing the manufacturer of the car
        protected int numCylinders;
        protected Person owner;

        // Constructors
        public Vehicle() { // No Arg Constructor
            man = Manufacturer.Chevy;
            numCylinders = 6;
            owner = new Person();
        }

        public Vehicle(Manufacturer aMan, int aNum, Person aPerson) { // Constructor with arguments
            man = aMan;
            numCylinders = aNum;
            owner = aPerson;
        }

        // Getters and Setters
        public Manufacturer GetManufacturer() {
            return man;
        }

        protected void setManufacturer(Manufacturer aMan) {
            man = aMan;
        }

        public int getNumCylinders() {
            return numCylinders;
        }

        protected void setNumCylinders(int aNum) {
            numCylinders = aNum;
        }

        public Person getOwner() {
            return owner;
        }

        protected void setOwner(Person aPerson) {
            owner = aPerson;
        }

        // Other Methods
        public override string ToString() {
            return "Manufacturer: " + GetManufacturer() + "\nNumber of Cylinders: " + getNumCylinders() + "\nOwner: " + getOwner();
        }

        public bool Equals(Vehicle aVehicle) {
            if (aVehicle.GetManufacturer() == GetManufacturer() && aVehicle.getOwner() == getOwner() && aVehicle.getNumCylinders() == getNumCylinders()) {
                return true;
            } else {
                return false;
            }
        }
    }

    class Truck : Vehicle {
        // Instance Variables
        double loadCapacity;
        int towCapacity;

        // Constructors
        public Truck() { // No Arg
            man = Manufacturer.Chevy;
            numCylinders = 6;
            owner = new Person();
            loadCapacity = 500;
            towCapacity = 750;
        }

        public Truck(Manufacturer aMan, int aNum, Person aPerson, double aLoadCap, int aTowCap) { // Constructors with arguments
            man = aMan;
            numCylinders = aNum;
            owner = aPerson;
            loadCapacity = aLoadCap;
            towCapacity = aTowCap;
        }

        // Getters and Setters
        public double getLoadCapacity() {
            return loadCapacity;
        }

        private void setLoadCapacity(double aLoadCap) {
            loadCapacity = aLoadCap;
        }

        public int getTowCapacity() {
            return towCapacity;
        }

        private void setTowCapacity(int aTowCap) {
            towCapacity = aTowCap;
        }

        // Other Methods
        public override String ToString() {
            return base.ToString() + "\nLoad Capacity: " + getLoadCapacity() + "\nTow Capacity: " + getTowCapacity();
        }
    }

    class Person {
        // Instance Variables
        private string name;

        // Constructors
        public Person() { // Default No Arg
            name = "Hugh Mungus";
        }

        public Person(string aName) { // Constructor with argument
            name = aName;
        }

        public Person (Person aPerson) { // Copy Constructor
            name = aPerson.getName();
        }

        // Getters and Setters
        public string getName() {
            return name;
        }

        private void setName(string aName) {
            name = aName;
        }

        // Other Methods
        public override string ToString() {
            return getName();
        }

        public bool Equals(Object obj) {
            if (obj.ToString() == ToString()) {
                return true;
            } else {
                return false;
            }
        }



    }

    // Enum
    public enum Manufacturer {
        Chevy,
        Ford,
        Toyota,
        Honda,
        Fiat
    }
}
