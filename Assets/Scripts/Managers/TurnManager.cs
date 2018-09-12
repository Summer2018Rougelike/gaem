using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {
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
        
    }

    // Update is called once per frame
    void Update () {
        switch (currentState) {
            case BATTLESTATES.START:
                break;
            case BATTLESTATES.PLAYERTURN:
                Debug.Log(currentState);
                GameManager.Instance.getEnemy().GetComponent<CharacterHolder>().getCharacter().receiveDamage(
                    GameManager.Instance.getAttackingPlayer().GetComponent<CharacterHolder>().getCharacter().dmg
                    );
                if (GameManager.Instance.getEnemy().GetComponent<CharacterHolder>().getCharacter().hp <= 0)
                    GameManager.Instance.getEnemy().SetActive(false);
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

    public void changeTurn() {
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
