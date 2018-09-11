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
            CombatSystem comsys = this.GetComponentInParent<CombatSystem>();

            statOfParent = comsys.getStat();

            dead = false;
        }
        public void receiveDamage(int damage) {
            if (!dead) {
                if (statOfParent == null)
                    Debug.Log("null geldi ya stat");
                statOfParent.setCurrentHealth(statOfParent.getCurrentHealth() - damage);
                if (statOfParent.getCurrentHealth() <= 0)
                    dead = true;
            }
        }
    }
}
