using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int totalScore;
    public int maxtime = 360;
    public int BossScore = 500;

    public Transform player;


    

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z);
    }
}
