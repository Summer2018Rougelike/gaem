using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    private enum State {FOLLOWING, WAITING, RUNNING};

    private Animator anim;
    private Rigidbody2D rb;
    private Rigidbody2D followRb;
    public GameObject objToFollow;
    private State state;
    public float FOV;
    private Vector2 diff;
    public int movSpeed;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        followRb = objToFollow.GetComponent<Rigidbody2D>();
    }

	
	// Update is called once per frame
	void Update () {
        diff = new Vector2(this.transform.position.x - objToFollow.transform.position.x, 
            this.transform.position.y - objToFollow.transform.position.y);

        if (diff.magnitude < FOV) {
            state = State.FOLLOWING;
        }

        else {
            state = State.WAITING;
        }
		
	}

    private void FixedUpdate() {
        if (state == State.FOLLOWING) {
            float atan = Mathf.Atan2(diff.y, diff.x);
            float movY = Mathf.Sin(atan) * movSpeed;
            float movX = Mathf.Cos(atan) * movSpeed;
            Debug.Log(movX + " ===== " + movY);
            rb.velocity = - new Vector2(movX, movY);

        }

        else {
            rb.velocity = Vector2.zero;
        }

    }
}
