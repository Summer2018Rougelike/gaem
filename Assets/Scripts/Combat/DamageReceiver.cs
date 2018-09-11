using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Combat {
    public class DamageReceiver : Component {
        private Stat statOfParent;
        private bool dead;
        public DamageReceiver() {
            statOfParent = this.GetComponentInParent<CombatSystem>().GetComponent<Stat>();
            dead = false;
        }
        public void receiveDamage(int damage) {
            if (!dead) {
                statOfParent.setCurrentHealth(statOfParent.getCurrentHealth() - damage);
                if (statOfParent.getCurrentHealth() <= 0)
                    dead = true;
            }
        }
    }
}
