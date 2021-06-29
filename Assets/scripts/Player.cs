using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed = 4;
    public float jumpForce = 5;

    private bool jumpOrder;
    private Rigidbody2D rbody;
    private Animator myAnimator;
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        jumpOrder |= Input.GetButtonDown("Jump");
    }

    private void FixedUpdate()
    {
        var velocity = rbody.velocity;

        velocity.x = Input.GetAxis("Horizontal") * movespeed;
        myAnimator.SetBool("walk", Input.GetButton("Horizontal"));
        if (Input.GetButton("Horizontal"))
        {
            sprite.flipX = velocity.x < 0;
        }
        if (jumpOrder)
        {
            velocity.y = jumpForce;
            jumpOrder = false;
        }

        rbody.velocity = velocity;
    }
}
