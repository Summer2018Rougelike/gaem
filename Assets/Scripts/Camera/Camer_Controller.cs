using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_Controller : MonoBehaviour {
    public GameObject followTarget;
    private Vector3 targetPos;
    public float movespeed;
    private static bool cameraExists;


	// Use this for initialization
	void Start () {

        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else

        {

            Destroy(gameObject);

            }

    }
	
	// Update is called once per frame
	void Update () {

        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, movespeed * Time.deltaTime);

		
	}
}
