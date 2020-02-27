using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BugMovement : MonoBehaviour
{
    public Transform player;

    public Slider bossHealthBar;
    public float health;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        bossHealthBar.value = health;

        if (player != null)
        {

        }

        if (health <= 0)
        {
          //  Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss Health is " + health);
    }

}
