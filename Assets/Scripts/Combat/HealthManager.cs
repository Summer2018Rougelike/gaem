using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {
    public int currHp;
    public int maxHp;
    public PlayerStats playerStats;
    public EnemyStats enemyStats;
	// Use this for initialization
	void Start () {
        if (gameObject.tag.Equals("Player")) {
            playerStats = this.GetComponent<PlayerStats>();
            maxHp = playerStats.hp;

        }
        else if (gameObject.tag.Equals("Enemy")) {
            enemyStats = this.GetComponent<EnemyStats>();
            maxHp = enemyStats.hp;
        }

        currHp = maxHp;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void dealDamage(int damage) {
        if (gameObject == null)
            return;
        if (damage < 0)
            damage = 1;
        currHp -= damage;
        if (currHp <= 0)
            Destroy(gameObject);
            
    }
}
