using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //variable for walking speed
    public float speed = 5;

    //Private animator and rigidbody2d
    private Animator anim;
    private Rigidbody2D myRigidbody;

    //bool for if player is moving and Vector2 to hold the players last move values (x,y)
    private bool playerMoving;
    private Vector2 lastMove;

    private SpriteRenderer playerSprite;


    void Start()
    {
        //get the animator
        anim = GetComponent<Animator>();
        //Get the rigidbody
        myRigidbody = GetComponent<Rigidbody2D>();

        playerSprite = gameObject.GetComponent<SpriteRenderer>();


    }

    void FixedUpdate()
    {
        //MOVEMENT SCRIPTING

        float horMovement = 0;
        float vertMovement = 0;


        //If axis for horizontal
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {

            if (Input.GetAxisRaw("Horizontal") > 0.5f)
            {
                playerSprite.flipX = true;
            }
            else
            {
                playerSprite.flipX = false;
            }

        }

        if (Input.GetAxisRaw("Horizontal") > 0.5f)
        {
            horMovement = 1 * speed;
        }

        if (Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            horMovement = -1 * speed;
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f)
        {
            vertMovement = 1 * speed;
        }
        
        if (Input.GetAxisRaw("Vertical") < -0.5f)
        {
            vertMovement = -1 * speed;
        }

        //set the rigidBody velocity to those values for x and y, and z to 0
        myRigidbody.velocity = new Vector3(horMovement, vertMovement, 0);

        if (Input.GetAxisRaw("Vertical") == 0f && Input.GetAxisRaw("Horizontal") == 0f)
        {
            myRigidbody.velocity = Vector3.zero;
            myRigidbody.angularVelocity = 0;

        }

        /*

        //ANIMATION SCRIPTING
        //Basis for animator code, currently unused

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("PlayerMoving", playerMoving);

         */

    }

}
