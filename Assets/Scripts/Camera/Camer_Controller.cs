using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camer_Controller : MonoBehaviour {
    public GameObject followTarget;
    private Vector3 targetPos;
    public float movespeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, movespeed * Time.deltaTime);

		
	}
}
