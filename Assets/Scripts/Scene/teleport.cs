using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {

    public string levelToLoad;
    public string exitPoint;
    private Movement player;


    // Use this for initialization
    void Start () {

        player = FindObjectOfType<Movement>();
        player.startPoint = exitPoint;

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
