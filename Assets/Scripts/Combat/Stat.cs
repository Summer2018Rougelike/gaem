using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Combat {

    public class Stat : Component {
        [Header("Player Stats")]
        public int maxHealth;


        private int currentHealth;

        public Stat(int maxHealth) {
            this.maxHealth = maxHealth;
            currentHealth = maxHealth;
        }



        public int getCurrentHealth() {
            return currentHealth;
        }

        public void setCurrentHealth(int newHealth) {
            currentHealth = newHealth;
        }

    }
}
