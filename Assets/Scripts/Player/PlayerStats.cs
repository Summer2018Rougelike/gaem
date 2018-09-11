using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int str;
 // public int per;
    public int end;
 // public int chr;
 // public int intl;
    public int agi;
    public int lck;
    public int xp;
    public int lvl;
    public int dmg;
    public int hp;
    public int arm;
    public int atk;
    public int crt;

    // Use this for initialization
    void Start () {

        dmg = str;
        hp = end*3;
        atk = agi;
        crt = lck;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
