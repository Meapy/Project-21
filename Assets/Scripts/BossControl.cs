using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossControl : MonoBehaviour
{
    public float speed;
    public float startTimeBetweenShots;
    private float timeBetweenShots;

    public GameObject BossProjectile1;
    private Transform player;
    public GameObject deathEffect;

    public Slider bossHealthBar;
    public float health;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        bossHealthBar.value = health;

        if (timeBetweenShots <= 0)
        {
            Instantiate(BossProjectile1, transform.position, Quaternion.identity);
            //transform.position = transform.position + new Vector3(1,0,0);
            //Instantiate(BossProjectile1, transform.position, Quaternion.identity);
            timeBetweenShots = startTimeBetweenShots;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss Health is " + health);
    }
}

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float threshold; // Makes sure characters is still on the map
    public Transform feetPos;
 
    public float health;
    public GameObject deathEffect;

    private Animator anim;
    public Slider bossHealthBar;

    public Transform player;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        bossHealthBar.value = health;

        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss Health is " + health);
    }
 }

 */
