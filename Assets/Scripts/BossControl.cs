using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;
    public float threshold; // Makes sure characters is still on the map


    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround; // checks what ground type it is ie. if its slime : can make character slower

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    private Animator anim;

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);



        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            anim.SetBool("isJumping", true);
        }
        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        //Can remove this lataer as boss will not be falling out of map, or keep as a fail safe ? lul
        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(4, -1, -7);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
