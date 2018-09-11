using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.Combat;

public class CombatSystem : MonoBehaviour {
    public int maxHealth = 700;

    DamageReceiver damageReceiver;
    Stat stat;

	// Use this for initialization
	void Awake () {
        stat = new Stat(maxHealth);
        damageReceiver = new DamageReceiver();
	}

    private void Start() {
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    public Stat getStat() { return stat; }
    public DamageReceiver getDamageReceiver() { return damageReceiver; }
}
