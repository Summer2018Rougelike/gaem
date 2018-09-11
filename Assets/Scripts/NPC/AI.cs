using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
    private enum State {FOLLOWING, WAITING, RUNNING};

    private Animator anim;
    private Rigidbody2D rb;
    private Rigidbody2D followRb;
    private GameObject objToFollow;
    private State state;
    public float FOV;
    private Vector2 diff;
    public int movSpeed;
    public int range;
    private Vector2 lastMove;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        objToFollow = GameObject.FindGameObjectWithTag("Player");
        followRb = objToFollow.GetComponent<Rigidbody2D>();
    }

	
	// Update is called once per frame
	void Update () {
        diff = new Vector2(this.transform.position.x - objToFollow.transform.position.x, 
            this.transform.position.y - objToFollow.transform.position.y);

        if (diff.magnitude <= FOV && diff.magnitude >= range) {
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
            lastMove = new Vector2(-movX, -movY);
            rb.velocity = lastMove;
            anim.SetFloat("MoveX", -movX);
            anim.SetFloat("MoveY", -movY);
            anim.SetBool("Moving", true);
        }

        else {
            rb.velocity = Vector2.zero;
            anim.SetBool("Moving", false);
            anim.SetFloat("LastMoveX", lastMove.x);
            anim.SetFloat("LastMoveY", lastMove.y);

        }





    }
}
