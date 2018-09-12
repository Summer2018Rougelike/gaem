using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character {
    public class Player : BaseCharacter {
        private int lives;

        public int getLives() { return lives; }
        public void setLives(int lives) { this.lives = lives; }

        public Player(Type charType, string name) : base(charType, name) {
        }

       
    }
}

