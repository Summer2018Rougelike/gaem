using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startpoint : MonoBehaviour {
    public Movement player;
    private CameraCont camera;
    public Vector2 startDir;
    public string dirName;




	// Use this for initialization
	void Start () {

        player = FindObjectOfType<Movement>();

        if (player.startPoint == dirName)
        {
            player.transform.position = transform.position;
            camera = FindObjectOfType<CameraCont>();
            camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
            player.lastMove = startDir;

            player.transform.position = transform.position;
            camera = FindObjectOfType<CameraCont>();
            camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
        }
        player.lastMove = startDir;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
