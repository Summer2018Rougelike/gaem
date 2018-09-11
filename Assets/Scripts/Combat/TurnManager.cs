using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {
    GameObject player;
    GameObject currentEnemy;
    GameObject[] enemies;
    public enum BATTLESTATES {
        START,
        PLAYERTURN,
        ENEMYTURN,
        WIN,
        LOSE
    };

    private BATTLESTATES currentState;

	// Use this for initialization
	void Start () {
        currentState = BATTLESTATES.START;
        player = GameObject.FindGameObjectWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(currentState);
        switch (currentState) {
            case BATTLESTATES.START:
                break;
            case BATTLESTATES.PLAYERTURN:
                for (int i = 0; i<enemies.Length; i++) {
                    if (enemies[i].GetComponent<EnemyStats>().getIsCurrent()) {
                        currentEnemy = enemies[i];
                        break;
                    }

                }
                if (currentEnemy)
                    currentEnemy.GetComponent<HealthManager>().dealDamage(player.GetComponent<PlayerStats>().dmg);
                changeTurn();
                break;
            case BATTLESTATES.ENEMYTURN:
                //changeTurn();
                break;
            case BATTLESTATES.WIN:
                break;
            case BATTLESTATES.LOSE:
                break;
        }
    }

    private void OnGUI() {
        if (GUILayout.Button("NEXT STATE")) {
            changeTurn();
        }
    }

    private void changeTurn() {
        if (currentState == BATTLESTATES.START) {
            currentState = BATTLESTATES.PLAYERTURN;
        }

        else if (currentState == BATTLESTATES.PLAYERTURN) {
            currentState = BATTLESTATES.ENEMYTURN;
        }

        else if (currentState == BATTLESTATES.ENEMYTURN) {
            currentState = BATTLESTATES.PLAYERTURN;
        }
    }
}
