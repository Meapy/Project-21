using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public int totalScore;
    public int maxtime = 360;
    public int BossScore = 500;
    public int timeleft;

    public Transform player;
    public TextMeshProUGUI scoreText;


    
    // Update is called once per frame
    void Update()
    {
        for(int i = maxtime * 60; i > 0; i--)
        {
            timeleft = i;
        }
        scoreText.text = 0.ToString();
        scoreText.text = totalScore.ToString() + timeleft.ToString();
    }
}
