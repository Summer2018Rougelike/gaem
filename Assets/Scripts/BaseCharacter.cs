using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character {

    public class BaseCharacter {

        public BaseCharacter(Type charType, string name) {
            this.charType = charType;
            this.name = name;
        }
        public enum Type {
            WARRIOR,
            MAGE
        }

        public string name { get; set; }
        private Type charType { get; set; }
        public int str { get; set; }
        // public int per;
        public int end { get; set; }
        // public int chr;
        // public int intl;
        public int agi { get; set; }
        public int lck { get; set; }
        public int curxp { get; set; }
        public int lvl { get; set; }
        public int dmg { get; set; }
        public int hp { get; set; }
        public int arm { get; set; }
        public int atk { get; set; }
        public int crt { get; set; }
        public int xptolvlup { get; set; }
        public int[] tolevelup { get; set; }
        public int statpoints { get; set; }

        public void receiveDamage(int receivedDamage) {
            this.hp -= receivedDamage;
            Debug.Log("Current hp is " + hp);
        }
    }
}
