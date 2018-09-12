using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace character { 
    public class CharacterManager : MonoBehaviour {

	    // Use this for initialization
	    void Start () {
		
	    }
	
	    // Update is called once per frame
	    void Update () {
		
	    }


        public GameObject createPlayer(BaseCharacter.Type charType, string name) {
            //GameObject createdPlayerObject = new GameObject(name);
            GameObject createdPlayerObject = GameObject.FindGameObjectWithTag("Player");
            Player createdPlayer = new Player(charType, name);

            createdPlayer.setLives(3);
            createdPlayer.str = 5;
            createdPlayer.end = 7;
            createdPlayer.agi = 9;
            createdPlayer.lck = 6;

            switch (charType) {
                case BaseCharacter.Type.WARRIOR:
                    createdPlayer.dmg = createdPlayer.str * 2;
                    createdPlayer.hp = createdPlayer.end * 3;
                    createdPlayer.atk = createdPlayer.agi * 2;
                    createdPlayer.crt = createdPlayer.lck;
                    break;
                case BaseCharacter.Type.MAGE:
                    createdPlayer.dmg = createdPlayer.str * 1;
                    createdPlayer.hp = createdPlayer.end * 4;
                    createdPlayer.atk = createdPlayer.agi;
                    createdPlayer.crt = createdPlayer.lck;
                    break;
            }

            createdPlayerObject.AddComponent<CharacterHolder>();
            createdPlayerObject.GetComponent<CharacterHolder>().assignCharacter(createdPlayer);

            return createdPlayerObject;
        }

        public GameObject createEnemy(BaseCharacter.Type charType, string name) {
            //GameObject createdEnemyObject = new GameObject(name);
            GameObject createdEnemyObject = GameObject.FindGameObjectWithTag("Enemy");
            Enemy createdEnemy = new Enemy(charType, name);

            createdEnemy.setLootAmount(9);
            createdEnemy.str = 5;
            createdEnemy.end = 7;
            createdEnemy.agi = 9;
            createdEnemy.lck = 6;

            switch (charType) {
                case BaseCharacter.Type.WARRIOR:
                    createdEnemy.dmg = createdEnemy.str * 2;
                    createdEnemy.hp = createdEnemy.end * 3;
                    createdEnemy.atk = createdEnemy.agi * 2;
                    createdEnemy.crt = createdEnemy.lck;
                    break;
                case BaseCharacter.Type.MAGE:
                    createdEnemy.dmg = createdEnemy.str * 1;
                    createdEnemy.hp = createdEnemy.end * 4;
                    createdEnemy.atk = createdEnemy.agi;
                    createdEnemy.crt = createdEnemy.lck;
                    break;
            }
            
            createdEnemyObject.AddComponent<CharacterHolder>();
            createdEnemyObject.GetComponent<CharacterHolder>().assignCharacter(createdEnemy);

            return createdEnemyObject;
        }
    }
}