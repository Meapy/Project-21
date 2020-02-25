﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdMovement : MonoBehaviour
{
    //public float moveSpeed;
    //private bool moveRight;

    public float xPosition; // used to set the x axis of the bird

    public Slider bossHealthBar;
    public float health;
    public static float bossHealth;

    public GameObject deathEffect;

    private Transform player;

    public float startTimeBetweenShots;
    private float timeBetweenShots1;
    private float timeBetweenShots2;
    public GameObject BirdProjectile;
    public GameObject BirdProjectileLow;


    // Start is called before the first frame update
    void Start()
    {
        //moveRight = true;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            bossHealthBar.value = health;
            bossHealth = health;
            /*
            if (player != null)
            {

                if (transform.position.x > xPosition)
                {
                    moveRight = false;
                    transform.localRotation = Quaternion.Euler(0, 180, 0);
                }
                else if (transform.position.x < xPosition - 2f)
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
            }*/
            // Boss Shooting
            if (bossHealth > 71)
            {
                if (timeBetweenShots1 <= 0)
                {
                    Instantiate(BirdProjectile, transform.position, Quaternion.identity); // creates projectile from BossProjectile1
                    timeBetweenShots1 = startTimeBetweenShots; // Limits boss to shooting only a certain amount of times
                }
                else
                {
                    timeBetweenShots1 -= Time.deltaTime; // Counts down timer before boss can shoot again
                }
            }
            if(bossHealth < 71)
            {   
                if (timeBetweenShots2 <= 0)
                {
                    Instantiate(BirdProjectileLow, transform.position, Quaternion.identity); // creates projectile from BossProjectile1
                    timeBetweenShots2 = startTimeBetweenShots; // Limits boss to shooting only a certain amount of times
                }
                else
                {
                    timeBetweenShots2 -= Time.deltaTime; // Counts down timer before boss can shoot again
                }
            }

            if (health <= 0)
            {
                //Instantiate(deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);

            }
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss Health is " + health);
    }
}
