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

    public int level1score = 0;
    public int level2score = 0;
    public int level3score = 0;

    public static int Level1Highscore = 0;
    public static int Level2Highscore = 0;
    public static int Level3Highscore = 0;

    public bool countdown = false;

    public Transform player;
    public TextMeshProUGUI scoreText;


    void Start()
    {
        startTime = maxtime;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown == false)
        {
            countdown = true;
            StartCoroutine(TimeCountdown());
        }
        
    }


    IEnumerator TimeCountdown()
    {

        startTime--;
        timeleft = startTime;
        totalScore = (timeleft + BossScore);
        scoreText.text = totalScore.ToString();
        yield return new WaitForSeconds(1);
        countdown = false;

    }
}
