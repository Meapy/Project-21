using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    Vector2 movement;

    public Animator animator;
    public float health;
    public Slider playerHealthBar;
    public Transform enemy;
    public Transform swamp;
    public GameObject deathEffect;
    public GameObject hitEffect;

    public GameObject LightDrop;

    void Start()
    {
     //   anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        swamp = GameObject.FindGameObjectWithTag("Swamp").transform;
    }
    
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);
        
        playerHealthBar.value = health;

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            //Instantiate(deathEffect, transform.position, Quaternion.identity);
            //Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Score.totalScore <= 0)
            {
                Debug.Log("you need more score to place a light");
            }
            else
            {
                Instantiate(LightDrop, transform.position, Quaternion.identity);
                Score.totalScore -= 10;
                Debug.Log("Light has been placed, 10 score has been taken away");

            }
            
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player Health is " + health);
        animator.SetTrigger("isHurt");
        StartCoroutine(TimeCountdown());
        animator.SetTrigger("isIdle");
        animator.SetTrigger("isMove");
    }
    IEnumerator TimeCountdown()
    {
        yield return new WaitForSeconds(0.5f);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Detected");
        GameObject e = Instantiate(hitEffect) as GameObject;
        e.transform.position = transform.position;
        other.gameObject.SetActive(false);
        TakeDamage(10);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}            /*
        if (movement.x > 0)
        {
            //transform.eulerAngles = new Vector3(0, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (movement.x < 0)
        {
            //transform.eulerAngles = new Vector3(0, 180, 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        // ^^ Flips the image of player around so there is no need to create as many sprites
        
        
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player Health is " + health);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Detected");
        GameObject e = Instantiate(hitEffect) as GameObject;
        e.transform.position = transform.position;
        other.gameObject.SetActive(false);
        TakeDamage(10);
    }

}

// Keep this code for when adding animations :) 
/*
public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private float moveInput;
    public float threshold;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround; // checks what ground type it is ie. if its slime : can make character slower

    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        //animator.SetFloat("speed", Mathf.Abs(speed));

        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (isGrounded == true & Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("isJumping", true);
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else {
            anim.SetBool("isJumping", true);
        }

        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else {
            anim.SetBool("isRunning", true);
        }

        if (transform.position.y < threshold)
        {
            transform.position = new Vector3(-4, -1, -3);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
*/

/*
public class Movement2D : MonoBehaviour
{
//Variables
public float movementSpeed = 5f;
public bool isGrounded = false;


// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{
    Jump();
    Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
    transform.position += movement * Time.deltaTime * movementSpeed;
}

void Jump()
{
    if (Input.GetButtonDown("Jump") && isGrounded == true)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
    }
}
}
*/
