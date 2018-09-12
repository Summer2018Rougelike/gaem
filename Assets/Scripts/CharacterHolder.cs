using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using character;
public class CharacterHolder : MonoBehaviour {
    public BaseCharacter characterOfObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void assignCharacter(BaseCharacter characterOfObj) {
        this.characterOfObj = characterOfObj;
    }

    public BaseCharacter getCharacter() { return characterOfObj; }
}
