﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{

    public int totalScore;
    public int maxtime = 360;
    public int BossScore = 500;
    public int timeleft;
    public int startTime;
    public int level;

    public int level1score = 0;
    public int level2score = 0;
    public int level3score = 0;

    public static int Level1Highscore = 0;
    public static int Level2Highscore = 0;
    public static int Level3Highscore = 0;

    public static int BossKill;

    public bool countdown = false;

    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI HighscoreText;
    public TextMeshProUGUI TimeLeftText;


    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        startTime = maxtime;
        if (sceneName == "Level 1")
        {
            level = 1;
        }
        else if (sceneName == "Level 2")
        {
            level = 2;
        }
        else if (sceneName == "Level 3")
        {
            level = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown == false)
        {
            countdown = true;
            StartCoroutine(TimeCountdown());
        }
        if(level1score > Level1Highscore)
        {
            Level1Highscore = level1score;
            HighscoreText.text = totalScore.ToString();
        }
        if (level2score > Level2Highscore)
        {
            Level2Highscore = level2score;
            HighscoreText.text = totalScore.ToString();
        }
        if (level3score > Level3Highscore)
        {
            Level3Highscore = level3score;
            HighscoreText.text = totalScore.ToString();
        }

    }


    IEnumerator TimeCountdown()
    {
        startTime--;
        timeleft = startTime;
        totalScore = BossScore + BossKill;
        if (level == 1)
        {
            level1score = totalScore;   
        }
        else if (level == 2)
        {
            level2score = totalScore;
        }
        else if (level == 3)
        {
            level3score = totalScore;
        }
        scoreText.text = totalScore.ToString();
        TimeLeftText.text = timeleft.ToString();
        yield return new WaitForSeconds(1);
        countdown = false;


    }
}
