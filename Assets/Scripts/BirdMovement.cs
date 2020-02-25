using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdMovement : MonoBehaviour
{
    public float moveSpeed;
    private bool moveRight;

    public Slider bossHealthBar;
    public float health;
    public GameObject deathEffect;

    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        bossHealthBar.value = health;

        if (player != null)
        {

            if (transform.position.x > 2f)
            {
                moveRight = false;
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            else if (transform.position.x < -2f)
            {
                moveRight = true;
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }

            if (moveRight)
            {
                transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);

            }
            else
            {
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            }
        }

        if (health <= 0)
        {
            //Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss Health is " + health);
    }
}
