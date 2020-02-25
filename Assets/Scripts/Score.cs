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
    public int startTime;

    public Transform player;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        startTime = maxtime * 60;
    }

    // Update is called once per frame
    void Update()
    {

        getScore();
        
    }

    void getScore()
    {
        startTime--;
        timeleft = startTime;
        totalScore = (timeleft + BossScore) / 60;
        scoreText.text = totalScore.ToString();
    }
}
