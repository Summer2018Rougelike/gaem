﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {

    public string levelToLoad;

    // Use this for initialization
    void Start () {
        

}
	
	// Update is called once per frame
	void Update () {
		
	}
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "PlayerChar")
        {

            SceneManager.LoadScene(levelToLoad);

        }

        
    }
}