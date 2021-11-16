using System;
using System.Collections.Generic;
using System.Text;

namespace AlienGame {
    class Alien {
        // Instance Variables
        protected int health; // 0 = dead, 100 = full
        protected int damage; // Amount of damage Alien does
        protected string name;

        // Constructors
        public Alien() { // Default No Arg
            health = 100;
            name = "E.T.";
            damage = 3;
        }

        public Alien(int aHealth, string aName) {
            health = aHealth;
            name = aName;
            damage = 10;
        }

        // Getters and Setters
        public int getDamage() {
            return damage;
        }

        public override string ToString() {
            return name + "\nDamage: " + getDamage() + "\n";
        }
    }

    // Alien SubClasses
    class SnakeAlien : Alien { // No difference from a normal Alien except for damage.
        public SnakeAlien() { // Default No Arg
            health = 100;
            name = "Snake Alien";
            damage = 10;
        }

        public SnakeAlien(int aHealth, string aName) {
            health = aHealth;
            name = aName;
            damage = 10;
        }
    }

    class OgreAlien : Alien { // No difference from a normal Alien except for damage.
        public OgreAlien() { // Default No Arg
            health = 100;
            name = "Ogre Alien";
            damage = 6;
        }

        public OgreAlien(int aHealth, string aName) {
            health = aHealth;
            name = aName;
            damage = 10;
        }
    }

    class MarshmallowManAlien : Alien { // No difference from a normal Alien except for damage.
        public MarshmallowManAlien() { // Default No Arg
            health = 100;
            name = "Marshmallow Man Alien";
            damage = 1;
        }

        public MarshmallowManAlien(int aHealth, string aName) {
            health = aHealth;
            name = aName;
            damage = 1;
        }
    }
}
