using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCont : MonoBehaviour {
    public GameObject followTarget;
    private Vector3 targetPos;
    public float movespeed;
    private static bool cameraExists;
    public GameObject bounds;
    public BoxCollider2D boundbox;
    private Vector3 minbounds;
    private Vector3 maxbounds;
    private Camera thecamera;
    private float halfheight;
    private float halfwidth;

	// Use this for initialization
	void Start () {

       bounds = GameObject.FindGameObjectWithTag("Bounds");
       boundbox = bounds.GetComponent<BoxCollider2D>();




        if (!cameraExists)
        {
            cameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else

        {

            Destroy(gameObject);

            }
        minbounds = boundbox.bounds.min;
        maxbounds = boundbox.bounds.max;
        thecamera = GetComponent<Camera>();
        halfheight = thecamera.orthographicSize;
        halfwidth = halfheight * Screen.width / Screen.height;
    }
	
	// Update is called once per frame
	void Update () {

        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, movespeed * Time.deltaTime);

        float clampedX = Mathf.Clamp(transform.position.x, minbounds.x + halfwidth, maxbounds.x - halfwidth);
        float clampedy = Mathf.Clamp(transform.position.y, minbounds.y + halfheight,maxbounds.y - halfheight);
        transform.position = new Vector3(clampedX, clampedy, transform.position.z);



    }
}
