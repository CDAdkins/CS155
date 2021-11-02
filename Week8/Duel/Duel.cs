/// Week 8 Homework 1
/// File Name: Duel.cs
/// @author: Chris Adkins
/// Date: 11/1/21
///
/// Problem Statement: This program simulates a duel between three people with varying skill levels. The simulation takes into account multiple strategies as well. 
/// 
/// Overall Plan
/// 1. Create a Duelist class with the duelists name, accuracy, and whether or not they are dead.
/// 2. Create a driver class with a duel simulation. This sim will run as many times as specified. Two simulations will exist to account for the two strategies.
/// 3. Output the results of each duel to the console after the simulations have been run.
///
/// Classes Needed and Purpose: 
/// Main Class: Duel - Driver class that contains the logic to simulate the duels with each of the two strategies.
/// Other Classes: Duelist - Class that contains data for the participants of the duel.

using System;

namespace Duel {
    class Duel {
        public static void Main(string[] args) {
            // Creating our duelists
            Duelist aaron = new Duelist("Aaron", 33.3);
            Duelist bob = new Duelist("Bob", 50);
            Duelist charlie = new Duelist("Charlie", 99.5);

            // Number of wins per duelist
            double aaronWins = 0;
            double bobWins = 0;
            double charlieWins = 0;

            int duels = 10000; // Number of duels to simulate
            int deadGuys = 0; // Number to keep track of dead duelists

            // Special use variable for the second strategy
            bool aaronFirstShot = true; // Used to determine if Aaron is firing his first shot of the duel

            for (int i = 0; i < duels; i++) {
                // Reviving our duelists
                aaron.resurrect();
                bob.resurrect();
                charlie.resurrect();
                deadGuys = 0;
                // Strategy where each Duelist fires at the best remaining shooter.
                while (deadGuys < 2) { // While we have more than one duelist standing

                    // Aaron's turn
                    if (charlie.isDead() == false) { // If Charlie is alive
                        aaron.shoot(charlie); // Shoot at Charlie
                        if (charlie.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    } else { // If Charlie is dead
                        aaron.shoot(bob); // Shoot at Bob
                        if (bob.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    }

                    // Bob's turn
                    if (charlie.isDead() == false) { // If Charlie is alive
                        bob.shoot(charlie); // Shoot at Charlie
                        if (bob.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    } else { // If Charlie is dead
                        bob.shoot(aaron); // Shoot at Aaron
                        if (aaron.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    }

                    // Charlie's turn
                    if (bob.isDead() == false) { // If Bob is alive
                        charlie.shoot(bob); // Shoot at Bob
                        if (bob.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    } else { // If Bob is dead
                        charlie.shoot(aaron); // Shoot at Aaron
                        if (aaron.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    }
                }
                // Checking to see who won, post duel
                if (aaron.isDead() == false) { // If Aaron wins
                    aaronWins++;
                } else if (bob.isDead() == false) { // If Bob  wins
                    bobWins++;
                } else { // if Charlie wins
                    charlieWins++;
                }
            }
            // Summarizing the duel
            Console.WriteLine("Aim for best shooter strategy\nDuels: " + duels + "\nAaron Wins: " + aaronWins + " - " + 
                Math.Round(aaronWins * 100 / duels, 2) + "%\nBob Wins: " + bobWins + " - " + Math.Round(bobWins * 100 / duels, 2) + 
                "%\nCharlie Wins: " + charlieWins + " - " + Math.Round(charlieWins * 100 / duels, 2) + "%\n");


             // Repeating all duels with the alternate strategy
            // Resetting win counts
            aaronWins = 0;
            bobWins = 0;
            charlieWins = 0;
            for (int i = 0; i < duels; i++) {
                // Reviving our duelists
                aaron.resurrect();
                bob.resurrect();
                charlie.resurrect();

                // Resetting duel parameters
                deadGuys = 0;
                aaronFirstShot = true;
                // Strategy where each Duelist fires at the best remaining shooter.
                while (deadGuys < 2) { // While we have more than one duelist standing

                    // Aaron's turn
                    if (charlie.isDead() == false && !aaronFirstShot) { // If Charlie is alive
                        aaron.shoot(charlie); // Shoot at Charlie
                        if (charlie.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    } else if (!aaronFirstShot) { // If Charlie is dead
                        aaron.shoot(bob); // Shoot at Bob
                        if (bob.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    }
                    aaronFirstShot = false;

                    // Bob's turn
                    if (charlie.isDead() == false) { // If Charlie is alive
                        bob.shoot(charlie); // Shoot at Charlie
                        if (bob.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    } else { // If Charlie is dead
                        bob.shoot(aaron); // Shoot at Aaron
                        if (aaron.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    }

                    // Charlie's turn
                    if (bob.isDead() == false) { // If Bob is alive
                        charlie.shoot(bob); // Shoot at Bob
                        if (bob.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    } else { // If Bob is dead
                        charlie.shoot(aaron); // Shoot at Aaron
                        if (aaron.isDead()) {
                            deadGuys++; // If the shot hit, increment deadGuys
                        }
                    }
                }
                // Checking to see who won, post duel
                if (aaron.isDead() == false) { // If Aaron wins
                    aaronWins++;
                } else if (bob.isDead() == false) { // If Bob  wins
                    bobWins++;
                } else { // if Charlie wins
                    charlieWins++;
                }
            }
            // Big write to console summarizing the duels
            Console.WriteLine("Aaron Missing the first shot on purpose strategy\nDuels: " + duels + "\nAaron Wins: " + aaronWins + " - " + 
                Math.Round(aaronWins * 100 / duels, 2) + "%\nBob Wins: " + bobWins + " - " + Math.Round(bobWins * 100 / duels, 2) + 
                "%\nCharlie Wins: " + charlieWins + " - " + Math.Round(charlieWins * 100 / duels, 2) + "%");
        }

        class Duelist { // Class to represent a participant in the duel
            private String name; // Name of duelist
            private double accuracy; // 0 to miss every time, 100 to hit every time.
            private bool dead; // Bool determining whether or not the duelist is dead
            
            // Constructors
            public Duelist() { // Default No arg
                name = "Billy the Kid";
                accuracy = 100;
                dead = false;
            }

            public Duelist(String aName, double anAccuracy) { // Constructor with arguments
                name = aName;
                accuracy = anAccuracy;
                dead = false;
            }

            // Getters and Setters
            public String getName() { // Returns the duelist's name
                return name;
            }

            private void setName(String aName) { // To change the duelist's name
                name = aName;
            }

            public double getAccuracy() { // returns the duelist's accuracy
                return accuracy;
            }

            private void setAccuracy(double anAccuracy) { // If you need to change a shooter's accuracy
                accuracy = anAccuracy;
            }

            public bool isDead() { // Check to see if duelist is dead
                return dead;
            }

            private void kill() { // If the duelist needs to die
                dead = true;
            }

            public void resurrect() { // Bring the duelist back to life
                dead = false;
            }

            // Other Methods
            public void shoot(Duelist target) {  // Shoot at a target, true if hit, false if miss
                Random rando = new Random();
                int shot = rando.Next(0, 100); // Generates a random number between 0 and 100

                if (!dead) {
                    if (shot <= accuracy) { // If the shooter is alive and random number is less than or equal to the accuracy of the shooter
                        target.kill(); // Kill the target
                        //Console.WriteLine(name + " kills " + target.getName());
                    } else {
                        //Console.WriteLine(name + " misses " + target.getName());
                    }
                }
            }

            // Printing the status of the duelist
            public override string ToString() {
                if (dead) {
                    return name + " is Dead.\n";
                } else {
                    return name + " is Alive.\n";
                }
            }
        }
    }
}
