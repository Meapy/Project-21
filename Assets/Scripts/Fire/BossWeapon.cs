/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    private GameObject playerObj = null;
    public Transform player;
    public static bool isPLayerAlive = true;
    public Transform shotPoint;
    private float timeBetweenShot;
    public float startTimeBetweenShot;
    public GameObject bossProjectile1;


    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
        }

        InvokeRepeating("CreateProjectile", 2.0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Player PosX: " + playerObj.transform.position.x + " PosY: " + playerObj.transform.position.y);

    }

    void CreateProjectile()
    {
        Instantiate(bossProjectile1);
        //Rigidbody instance = Instantiate(BossProjectile1);
        bossProjectile1.speed = Random.insideUnitSphere * 5;
    }
}

*/