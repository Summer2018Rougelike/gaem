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
                break;
            case BATTLESTATES.ENEMYTURN:
                StartCoroutine("waitBeforeChangeTurn", 5);
                break;
            case BATTLESTATES.WIN:
                break;
            case BATTLESTATES.LOSE:
                break;
        }
    }

    public void changeTurn() {
        Debug.Log(currentState);


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

    public IEnumerator waitBeforeChangeTurn(float seconds) {
        yield return new WaitForSeconds(seconds);
        changeTurn();
        StopCoroutine("waitBeforeChangeTurn");
        yield return null;
    }
}
