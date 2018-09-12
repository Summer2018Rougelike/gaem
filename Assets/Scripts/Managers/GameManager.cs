using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using character;

public class GameManager : MonoBehaviour {
    private GameObject attackingPlayer;

    public static GameManager Instance { get; private set; }

    private GameObject currentEnemy;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }


        else {
            Destroy(gameObject);
        }

        currentEnemy = GameObject.FindGameObjectWithTag("Enemy");
        attackingPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void markEnemy(GameObject enemy) {
        currentEnemy = enemy;
    } 

    public GameObject getEnemy() { return currentEnemy; }

    public void markAttakingPlayer(GameObject player) {
        attackingPlayer = player;
    } 

    public GameObject getAttackingPlayer() { return attackingPlayer; }

    private void OnGUI() {
        if (GUILayout.Button("Create Enemy")) {
            GameObject created = gameObject.GetComponent<CharacterManager>().createEnemy(BaseCharacter.Type.WARRIOR, "Test Enemy Wilson");
            Debug.Log("Created warrior character as enemy" + created);
        }

        if (GUILayout.Button("Create Player")) {
            GameObject created = gameObject.GetComponent<CharacterManager>().createPlayer(BaseCharacter.Type.MAGE, "Test Player Character");
            Debug.Log("Created mage character as player" + created);
        }

        if (GUILayout.Button("Change Turn")) {
            gameObject.GetComponent<TurnManager>().changeTurn();

        }
    }
}