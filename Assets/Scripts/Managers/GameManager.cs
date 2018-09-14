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
        currentEnemy.AddComponent<CharacterHolder>();
        currentEnemy.GetComponent<CharacterHolder>().assignCharacter(
            GameManager.Instance.GetComponent<CharacterManager>().createEnemy(BaseCharacter.Type.WARRIOR, "Wilson"));

        attackingPlayer.AddComponent<CharacterHolder>();
        attackingPlayer.GetComponent<CharacterHolder>().assignCharacter(
            GameManager.Instance.GetComponent<CharacterManager>().createPlayer(BaseCharacter.Type.WARRIOR, "Player"));
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
}