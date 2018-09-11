using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatmodif : MonoBehaviour {

    public int dmg;
    public int hp;
    public int arm;
    public int atk;
    public int crt;
    private PlayerStats playerstats;

	// Use this for initialization
	void Start () {

        dmg = playerstats.str;
        hp = playerstats.end;
        atk = playerstats.agi;
        crt = playerstats.lck;


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
