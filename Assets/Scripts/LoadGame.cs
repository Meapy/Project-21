using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoadGame : MonoBehaviour
{
    public TextMeshProUGUI Level1HighscoreDisplay;
    public TextMeshProUGUI Level2HighscoreDisplay;
    public TextMeshProUGUI Level3HighscoreDisplay;

    public static long Level1Highscore;
    public static long Level2Highscore;
    public static long Level3Highscore;


    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Level1Highscore = data.Level1Highscore;
        Level2Highscore = data.Level2Highscore;
        Level3Highscore = data.Level3Highscore;

    }
    void Update()
    {
        Level1Highscore = Score.Level1Highscore;
        Level2Highscore = Score.Level2Highscore;
        Level3Highscore = Score.Level3Highscore;
    }
}
