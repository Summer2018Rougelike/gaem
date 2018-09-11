using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed;
    private Animator anim;
    private bool ismoving;
    public Vector2 lastMove;
    private Rigidbody2D rigidBody;
    public string startPoint;
    private static bool playerexists;
   
        



	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();

        if (!playerexists)
        {
            playerexists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else

            {

            Destroy(gameObject);

            }
		
	}
	
	// Update is called once per frame
	void Update () {

    }
   void FixedUpdate()
    {

        ismoving = false;
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime;
        float moveVertical = Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime;

        if (moveHorizontal != 0)
        {
            ismoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if (moveVertical != 0)
        {

            ismoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));

        }
        rigidBody.velocity = (new Vector2(moveHorizontal, moveVertical));
        //transform.Translate(new Vector3(moveHorizontal, moveVertical));
        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("Moving", ismoving);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

    }
}
