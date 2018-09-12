using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character {
    public class Enemy : BaseCharacter {
        private int lootAmount;

        public int getLootAmount() { return lootAmount; }
        public void setLootAmount(int lootAmount) { this.lootAmount = lootAmount; }

        public Enemy(Type charType, string name) : base(charType, name) {
        }

    }
}

