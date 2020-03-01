using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelComplete : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public static long score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        if(Score.level == 1)
        {
            highscoreText.text = "Highscore: " + Score.Level1Highscore.ToString();

        }
        if (Score.level == 2)
        {
            highscoreText.text = "Highscore: " + Score.Level2Highscore.ToString();

        }
        if (Score.level == 3)
        {
            highscoreText.text = "Highscore: " + Score.Level3Highscore.ToString();

        }

    }
}
