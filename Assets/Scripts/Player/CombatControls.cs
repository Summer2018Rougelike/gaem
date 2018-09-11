using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Assets.Scripts.Combat;
public class CombatControls : MonoBehaviour {
    private bool attacking;
    public GameObject enemy;
    private DamageReceiver damageReceiver;
    private Stat stat;
    
	// Use this for initialization
	void Start () {
        attacking = false;
        enemy = GameObject.FindGameObjectWithTag("Enemy");
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space)) {
            attacking = true;
            Debug.Log("Attacked");
        }
		

        if (attacking) {
            this.damageReceiver = enemy.GetComponent<CombatSystem>().GetComponent<DamageReceiver>();
            this.stat = enemy.GetComponent<CombatSystem>().GetComponent<Stat>();
            damageReceiver.receiveDamage(10);
            Debug.Log("new health is " + stat.getCurrentHealth());
        }
	}
}


