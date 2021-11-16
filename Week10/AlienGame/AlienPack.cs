using System;
using System.Collections.Generic;
using System.Text;

namespace AlienGame {
    class AlienPack { // Pack of Multiple Aliens
        private Alien[] aliens;

        public AlienPack(int numAliens) { // Constructor creating an Alien Array given a number for size
            aliens = new Alien[numAliens];
        }

        public void addAlien(Alien anAlien, int index) {
            aliens[index] = anAlien; // Add the given alien to the array
        }

        public Alien[] getAliens() {
            return aliens;
        }

        public int calculateDamage() {
            int damage = 0;

            foreach (Alien a in aliens) {
                damage += a.getDamage(); // Get the damage from each alien and add it together
            }
            return damage;
        }
    }
}
